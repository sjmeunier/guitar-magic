using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MidiLib;

namespace GuitarMagic
{
    public partial class MainForm : Form
    {
        private MidiOut midiOut = new MidiOut();

        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo("settings.dat");
            if (f.Exists == true)
            {
                BinaryReader br = new BinaryReader(f.OpenRead());
                Globals.defaultDevice = br.ReadInt32();
                Globals.defaultInstrument = br.ReadInt16();
                Globals.defaultInputDevice = br.ReadInt32();
                Globals.inputSampleRate = br.ReadInt32();
                Globals.inputChannels = br.ReadInt32();

                br.Close();
            }

            if (midiOut.GetNumberDevices() == 0)
            {
                MessageBox.Show("This program requires a MIDI-capable sound card installed to work.", "Error", MessageBoxButtons.OK);
                this.Close();
            }
            Globals.midiDevices = midiOut.GetOutputDevices();

            midiOut.OpenMidiOut(Globals.midiDevices[Globals.defaultDevice].deviceId);
            midiOut.ProgramChange(0, 0, Globals.defaultInstrument);

            NoteFreq.SetFrequencies(Globals.standardAFrequency);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frequencyTableToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FreqencyTableForm frequencyTableForm1 = new FreqencyTableForm();
            frequencyTableForm1.MdiParent = this;
            frequencyTableForm1.SetMidi(ref midiOut);
            frequencyTableForm1.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            midiOut.CloseMidiOut();

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.MdiParent = this;
            configForm.SetMidi(ref midiOut);
            configForm.Show();
        }

        private void intervalFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntervalFinderForm intervalFinderForm = new IntervalFinderForm();
            intervalFinderForm.MdiParent = this;
            intervalFinderForm.Show();
        }

        private void chordChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChordChartForm chordChartForm = new ChordChartForm();
            chordChartForm.MdiParent = this;
            chordChartForm.SetMidi(ref midiOut);
            chordChartForm.Show();
        }

        private void metronomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetronomeForm metronomeForm = new MetronomeForm();
            metronomeForm.MdiParent = this;
            metronomeForm.SetMidi(ref midiOut);
            metronomeForm.Show();
        }

        private void scaleFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScaleFinderForm scaleFinderForm = new ScaleFinderForm();
            scaleFinderForm.MdiParent = this;
            scaleFinderForm.SetMidi(ref midiOut);
            scaleFinderForm.Show();

        }

        private void transposerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransposerForm transposerForm = new TransposerForm();
            transposerForm.MdiParent = this;
            transposerForm.Show();
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteFinderForm noteFinderForm = new NoteFinderForm();
            noteFinderForm.MdiParent = this;
            noteFinderForm.SetMidi(ref midiOut);
            noteFinderForm.Show();
        }

        private void chordFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChordFinderForm chordFinderForm = new ChordFinderForm();
            chordFinderForm.MdiParent = this;
            chordFinderForm.SetMidi(ref midiOut);
            chordFinderForm.Show();

        }

        private void tunerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TunerForm tunerForm = new TunerForm();
            tunerForm.MdiParent = this;
            tunerForm.Show();
        }

        private void spectralAnalyzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpectralAnalyzerForm spectralAnalyzerForm = new SpectralAnalyzerForm();
            spectralAnalyzerForm.MdiParent = this;
            spectralAnalyzerForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();

        }
    }
}
