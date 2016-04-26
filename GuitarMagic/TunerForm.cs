using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MathLib;
using MidiLib;
using Microsoft.DirectX.DirectSound;
using System.Threading;
using System.IO;
using ShapeControl;

namespace GuitarMagic
{
    public partial class TunerForm : Form
    {
        private object gLockObject = new object();
        private bool gStopRecording = false;
        private CaptureBufferDescription gBufferDescription = new CaptureBufferDescription();
        private AutoResetEvent gResetEvent;
        private Capture gCapture;
        private Notify gNotify;
        private CaptureBuffer gBuffer;
        private int gBufferSize;
        private int gSampleRate = Globals.inputSampleRate;
        private int gChannels = Globals.inputChannels;
        private double gFundamental = 0;
        private int gBitsPerSample = Globals.inputBits;
        private int gNote = 0;

        private ShapeControl.ShapeControl[] onMeter = new ShapeControl.ShapeControl[9];
        private ShapeControl.ShapeControl[] offMeter = new ShapeControl.ShapeControl[9];

        public TunerForm()
        {
            InitializeComponent();
            onMeter[0] = shpLeftOn4;
            onMeter[1] = shpLeftOn3;
            onMeter[2] = shpLeftOn2;
            onMeter[3] = shpLeftOn1;
            onMeter[4] = shpCenterOn;
            onMeter[5] = shpRightOn1;
            onMeter[6] = shpRightOn2;
            onMeter[7] = shpRightOn3;
            onMeter[8] = shpRightOn4;

            offMeter[0] = shpLeftOff4;
            offMeter[1] = shpLeftOff3;
            offMeter[2] = shpLeftOff2;
            offMeter[3] = shpLeftOff1;
            offMeter[4] = shpCenterOff;
            offMeter[5] = shpRightOff1;
            offMeter[6] = shpRightOff2;
            offMeter[7] = shpRightOff3;
            offMeter[8] = shpRightOff4;

            for (int i = 0; i < 9; i++)
            {
                onMeter[i].Visible = false;
                offMeter[i].Visible = true;
            }

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TunerForm_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblFundamental.Text = "Input Stopped";
            lblNote.Text = "";
            StopRec();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            gChannels = Globals.inputChannels; //Stereo
            gBitsPerSample = Globals.inputBits; //16Bit, alternatively use 8Bits
            gSampleRate = Globals.inputSampleRate; //11KHz use 11025 , 22KHz use 22050, 44KHz use 44100 etc

            //Set up the wave format to be captured
            WaveFormat waveFormat = new WaveFormat();
            waveFormat.Channels = (short)gChannels;
            waveFormat.FormatTag = WaveFormatTag.Pcm;
            waveFormat.SamplesPerSecond = gSampleRate;
            waveFormat.BitsPerSample = (short)gBitsPerSample;
            waveFormat.BlockAlign = (short)(gChannels * (gBitsPerSample / 8));
            waveFormat.AverageBytesPerSecond = waveFormat.BlockAlign * gSampleRate;

            gBufferDescription.BufferBytes = waveFormat.AverageBytesPerSecond / 5;//approx 200 milliseconds of pcm data
            gBufferDescription.Format = waveFormat;

            gBufferSize = gBufferDescription.BufferBytes;
            //gBuffer = new CaptureBuffer(gBufferDescription, gCapture);



            ThreadStart recorderStart = new ThreadStart(StartRec);
            Thread recorderThread = new Thread(recorderStart);
            recorderThread.Start();

        }

        private void CreateNotifyPositions()
        {
            gResetEvent = new AutoResetEvent(false);
            gNotify = new Notify(gBuffer);
            BufferPositionNotify bufferPositionNotify1 = new BufferPositionNotify();
            bufferPositionNotify1.Offset = gBufferSize / 2 - 1;
            bufferPositionNotify1.EventNotifyHandle = gResetEvent.Handle;
            BufferPositionNotify bufferPositionNotify2 = new BufferPositionNotify();
            bufferPositionNotify2.Offset = gBufferSize - 1;
            bufferPositionNotify2.EventNotifyHandle = gResetEvent.Handle;

            gNotify.SetNotificationPositions(new BufferPositionNotify[] { bufferPositionNotify1, bufferPositionNotify2 });
        }

        public void StopRec()
        {
            lock (gLockObject)
            {
                gStopRecording = true;
            }
        }

        public void StartRec()
        {
            double[] result = new double[(gSampleRate * 2) + 2];
            int halfBuffer = gBufferSize / 2;

            lock (gLockObject)
            {
                gStopRecording = false;
            }

            CaptureDevicesCollection captureDeviceCollection = new CaptureDevicesCollection();

            //Check that there is a capture device
            if (captureDeviceCollection.Count == 0)
                throw new Exception("No Capture Devices");

            //Using first one
            DeviceInformation deviceInfo = captureDeviceCollection[Globals.defaultInputDevice];

            gCapture = new Capture(deviceInfo.DriverGuid);
            //Check that we are able to record at 22KHz Stereo 16Bits per sample (fairly common)			
            CaptureCaps caps = gCapture.Caps;
            if (!caps.Format22KhzStereo16Bit)
                throw new Exception("Unable to record at 22KHz Stereo 16Bits");

            gBuffer = new CaptureBuffer(gBufferDescription, gCapture);
            CreateNotifyPositions();

            gBuffer.Start(true);

            bool readFirstBufferPart = true;
            int offset = 0;

            MemoryStream memStream = new MemoryStream(halfBuffer);

            while (true)
            {
                gResetEvent.WaitOne();
                memStream.Seek(0, SeekOrigin.Begin);
                gBuffer.Read(offset, memStream, halfBuffer, LockFlag.None);
                readFirstBufferPart = !readFirstBufferPart;
                offset = readFirstBufferPart ? 0 : halfBuffer;


                byte[] recData = memStream.GetBuffer();
                double[] convertedData = new double[(recData.Length / gChannels * (gBitsPerSample / 8))];
                int j = 0;
                int step = gChannels * (gBitsPerSample / 8);
                int max;
                if (recData.Length % 2 == 0)
                {
                    max = recData.Length;
                }
                else
                {
                    max = recData.Length - 1;
                }

                for (int i = 0; i < max; i += step)
                {
                    convertedData[j] = Convert.ToDouble(BitConverter.ToInt16(recData, i));
                    j++;
                }

                //Output to displays
                gFundamental = 0;
                double firstMax = 0;
                double secondMax = 0;
                double thirdMax = 0;
                int firstI = 0;
                int secondI = 0;
                int thirdI = 0;
                bool foundFirst = false;
                bool foundSecond = false;
                bool foundThird = false;

                for (int i = 1; i < convertedData.Length; i++)
                {
                    if (foundSecond == true && foundThird == true)
                    {
                        gFundamental += (double)gSampleRate / (double)(thirdI - secondI);
                        if (gFundamental > 0)
                        {
                            gFundamental /= 2;
                        }

                        foundThird = false;
                        secondI = thirdI;
                        secondMax = thirdMax;
                        thirdMax = 0;
                        thirdI = 0;
                    }

                    if (Math.Abs(convertedData[i]) > 400)
                    {
                        if ((foundFirst == false) && (foundSecond == false) && (foundThird == false))
                        {
                            if (convertedData[i] > firstMax)
                            {
                                firstMax = convertedData[i];
                                firstI = i;
                            }
                            if ((convertedData[i] < 0) && (firstMax > 0))
                            {
                                foundFirst = true;
                            }
                        }
                        if ((foundFirst == true) && (foundSecond == false) && (foundThird == false))
                        {
                            if (convertedData[i] > secondMax)
                            {
                                secondMax = convertedData[i];
                                secondI = i;
                            }
                            if ((convertedData[i] < 0) && (secondMax > 0))
                            {
                                foundSecond = true;
                            }
                        }
                        if ((foundFirst == true) && (foundSecond == true) && (foundThird == false))
                        {
                            if (convertedData[i] > thirdMax)
                            {
                                thirdMax = convertedData[i];
                                thirdI = i;
                            }
                            if ((convertedData[i] < 0) && (thirdMax > 0))
                            {
                                foundThird = true;
                            }

                        }

                    }
                }



                lock (gLockObject)
                {
                    if (gStopRecording)
                    {
                        gBuffer.Stop();
                        break;
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFundamental.Text = "Fundamental: No note";

            for (int i = 0; i < 9; i++)
            {
                onMeter[i].Visible = false;
                offMeter[i].Visible = true;
            }

            if (gFundamental > 10)
            {
                gNote = NoteFreq.FrequencyToNote(gFundamental);

                lblFundamental.Text = "Fundamental: " + gFundamental.ToString();
                lblNote.Text = NoteFreq.NoteNames[gNote % 12] + " " + ((gNote / 12) + 1).ToString();

                double freqDiff = NoteFreq.NoteToFrequency((short)gNote) - gFundamental;
                if (gNote == 0)
                    gNote = 1;
                if (gNote == 127)
                    gNote = 126;

                double diffToLower = NoteFreq.NoteToFrequency((short)gNote) - NoteFreq.NoteToFrequency((short)(gNote - 1));
                double diffToUpper = NoteFreq.NoteToFrequency((short)(gNote + 1)) - NoteFreq.NoteToFrequency((short)(gNote));
                if (gFundamental < NoteFreq.NoteToFrequency((short)gNote))
                {
                    double ratio = Math.Abs(freqDiff) / diffToLower;
                    if (ratio < 0.03)
                    {
                        onMeter[4].Visible = true;
                        offMeter[4].Visible = false;
                    }
                    else if (ratio < 0.13)
                    {
                        onMeter[3].Visible = true;
                        offMeter[3].Visible = false;
                    }
                    else if (ratio < 0.25)
                    {
                        onMeter[2].Visible = true;
                        offMeter[2].Visible = false;
                    }
                    else if (ratio < 0.38)
                    {
                        onMeter[1].Visible = true;
                        offMeter[1].Visible = false;
                    }
                    else
                    {
                        onMeter[0].Visible = true;
                        offMeter[0].Visible = false;
                    }
                }
                else
                {
                    double ratio = Math.Abs(freqDiff) / diffToLower;
                    if (ratio < 0.03)
                    {
                        onMeter[4].Visible = true;
                        offMeter[4].Visible = false;
                    }
                    else if (ratio < 0.13)
                    {
                        onMeter[5].Visible = true;
                        offMeter[5].Visible = false;
                    }
                    else if (ratio < 0.25)
                    {
                        onMeter[6].Visible = true;
                        offMeter[6].Visible = false;
                    }
                    else if (ratio < 0.38)
                    {
                        onMeter[7].Visible = true;
                        offMeter[7].Visible = false;
                    }
                    else
                    {
                        onMeter[8].Visible = true;
                        offMeter[8].Visible = false;
                    }
                }

            }


        }
    }
}
