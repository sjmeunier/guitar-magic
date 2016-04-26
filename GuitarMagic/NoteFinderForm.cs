using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MidiLib;

namespace GuitarMagic
{
    public partial class NoteFinderForm : Form
    {
        private MidiOut midiOut = null;
        private int[] gTuningNotes = new int[6];
        private int[] gNotes;
        private int gPlayNote = 0;

        public NoteFinderForm()
        {
            InitializeComponent();
        }

        public void SetMidi(ref MidiOut mOut)
        {
            midiOut = mOut;
        }

        private void ScaleFinderForm_Load(object sender, EventArgs e)
        {
            cboRoot.Items.Clear();
            for (int i = 0; i < NoteFreq.NoteNames.Length; i++)
            {
                cboRoot.Items.Add(NoteFreq.NoteNames[i]);
            }
            cboRoot.SelectedIndex = 0;

            cboScale.Items.Clear();

            string[] scaleNameList = DBAccess.GetAllScaleNames();
            for (int i = 0; i < scaleNameList.Length; i++)
            {
                cboScale.Items.Add(scaleNameList[i]);
            }
            cboScale.SelectedIndex = 0;

            string[] tuningNameList = DBAccess.GetAllTuningNames();
            for (int i = 0; i < tuningNameList.Length; i++)
            {
                cboTuning.Items.Add(tuningNameList[i]);
            }
            cboTuning.SelectedIndex = 0;

            SetTuning(Globals.defaultTuning);
        }

        private void SetTuning(string tuningName)
        {
            gTuningNotes = DBAccess.GetTuning(tuningName);

            txtS1.Text = NoteFreq.NoteNames[(gTuningNotes[0] % 12)];
            txtS2.Text = NoteFreq.NoteNames[(gTuningNotes[1] % 12)];
            txtS3.Text = NoteFreq.NoteNames[(gTuningNotes[2] % 12)];
            txtS4.Text = NoteFreq.NoteNames[(gTuningNotes[3] % 12)];
            txtS5.Text = NoteFreq.NoteNames[(gTuningNotes[4] % 12)];
            txtS6.Text = NoteFreq.NoteNames[(gTuningNotes[5] % 12)];
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            midiOut.AllNotesOff();
            this.Close();
        }

        private bool InArray(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            string scaleName = cboScale.SelectedItem.ToString();
            gNotes = DBAccess.GetScaleNotes(cboRoot.SelectedIndex, scaleName);

            string noteText = "";
            string intervalText = "";
            SetTuning(cboTuning.SelectedItem.ToString());
            for (int i = 0; i < gNotes.Length; i++)
            {
                noteText += NoteFreq.NoteNames[gNotes[i]] + "\t";
                intervalText += NoteFreq.IntervalNames[gNotes[i]] + "\t";
            }

            cmdPlay.Enabled = true;
            txtNotes.Text = noteText;
            txtIntervals.Text = intervalText;
            txtScale.Text = NoteFreq.NoteNames[cboRoot.SelectedIndex] + " " + scaleName;


            fretBoard1.HideFretPoints();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (InArray((gTuningNotes[i] + j) % 12, gNotes) == true)
                    {
                        fretBoard1.fretPoints[i, j].Visible = true;
                    }
                }
            }

        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            gPlayNote = 0;
            midiOut.AllNotesOff();
            timerPlay.Interval = Globals.playDelay;
            timerPlay.Enabled = true;
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            if (gPlayNote >= gNotes.Length)
            {
                timerPlay.Enabled = false;
                midiOut.AllNotesOff();
            }
            else
            {
                midiOut.NoteOn(0, (short)(gNotes[gPlayNote] + 60), 127);
                gPlayNote++;
            }
        }
    }
}
