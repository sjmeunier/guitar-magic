using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MidiLib;
using Microsoft.DirectX.DirectSound;

namespace GuitarMagic
{
    public partial class ConfigForm : Form
    {
        MidiOut midiOut = null;

        public ConfigForm()
        {
            InitializeComponent();
        }

        public void SetMidi(ref MidiOut mOut)
        {
            midiOut = mOut;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            listDevices.Items.Clear();
            for (int i = 0; i < Globals.midiDevices.Length; i++)
            {
                listDevices.Items.Add(Globals.midiDevices[i].deviceName);
            }
            listDevices.SelectedIndex = Globals.defaultDevice;

            listInstruments.Items.Clear();
         
            for (int i = 0; i < Enum.GetValues(typeof(GeneralMidiInstrument)).Length; i++)
            {
                listInstruments.Items.Add(Enum.GetName(typeof(GeneralMidiInstrument), i));
            }
            listInstruments.SelectedIndex = Globals.defaultInstrument;

            lstInputDevices.Items.Clear();
            CaptureDevicesCollection captureDeviceCollection = new CaptureDevicesCollection();
            for (int i = 0; i < captureDeviceCollection.Count; i++)
            {
                lstInputDevices.Items.Add(captureDeviceCollection[i].Description);
            }
            lstInputDevices.SelectedIndex = Globals.defaultInputDevice;

            cboChannels.SelectedIndex = Globals.inputChannels - 1;
            switch (Globals.inputSampleRate)
            {
                case 11025:
                    cboSampleRate.SelectedIndex = 0;
                    break;
                case 22050:
                    cboSampleRate.SelectedIndex = 1;
                    break;
                case 44100:
                    cboSampleRate.SelectedIndex = 2;
                    break;
            }
            
        }

        private void listInstruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.defaultInstrument = (short)listInstruments.SelectedIndex;
            midiOut.ProgramChange(0, 0, Globals.defaultInstrument);
        }

        private void listDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.defaultDevice = listDevices.SelectedIndex;
            midiOut.OpenMidiOut(Globals.midiDevices[Globals.defaultDevice].deviceId);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo("settings.dat");
            BinaryWriter bw = new BinaryWriter(f.OpenWrite());


            bw.Write(Globals.defaultDevice);
            bw.Write(Globals.defaultInstrument);
            bw.Write(Globals.defaultInputDevice);
            bw.Write(Globals.inputSampleRate);
            bw.Write(Globals.inputChannels);

            bw.Close();

            MessageBox.Show("Settings have been saved", "Saved", MessageBoxButtons.OK);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lstInputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.defaultInputDevice = lstInputDevices.SelectedIndex;

        }

        private void cboSampleRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSampleRate.SelectedIndex)
            {
                case 0:
                    Globals.inputSampleRate = 11025;
                    break;
                case 1:
                    Globals.inputSampleRate = 22050;
                    break;
                case 2:
                    Globals.inputSampleRate = 44100;
                    break;
            }

        }

        private void cboChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.inputChannels = cboChannels.SelectedIndex + 1;
        }
    }
}
