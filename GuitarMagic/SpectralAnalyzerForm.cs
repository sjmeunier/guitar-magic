using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MathLib;
using Microsoft.DirectX.DirectSound;
using System.Threading;
using System.IO;

namespace GuitarMagic
{
    public partial class SpectralAnalyzerForm : Form
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
        private int gBitsPerSample = Globals.inputBits;

        public SpectralAnalyzerForm()
        {
            InitializeComponent();
        }

        private void SpectralAnalyserForm_Load(object sender, EventArgs e)
        {
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                FFT.Transform(convertedData, convertedData.Length, gSampleRate, true, ref result);

                oscilloscope1.DrawSpectrum(ref convertedData, Int16.MaxValue, gSampleRate, convertedData.Length, 0.1);
                spectrumSpread1.DrawSpectrum(ref result, 1000000, false, convertedData.Length / 2);
                //Output to displays
            }
        }



        private void cmdStart_Click(object sender, EventArgs e)
        {
            
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

        private void cmdStop_Click(object sender, EventArgs e)
        {
            StopRec();
        }

        private void spectrumSpread1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
