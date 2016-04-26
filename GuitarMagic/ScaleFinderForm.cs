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
    public partial class ScaleFinderForm : Form
    {
        private MidiOut midiOut = null;
        private int[] gNotes = new int[12];
        private int[] gIntervals = new int[12];
        private int gStartNote = 0;

        private int gNumNotes = 0;
        private int gPlayNote = 0;
        private ComboBox[] cboNotes = new ComboBox[12];

        public ScaleFinderForm()
        {
            InitializeComponent();
            cboNotes[0] = cboNote0;
            cboNotes[1] = cboNote1;
            cboNotes[2] = cboNote2;
            cboNotes[3] = cboNote3;
            cboNotes[4] = cboNote4;
            cboNotes[5] = cboNote5;
            cboNotes[6] = cboNote6;
            cboNotes[7] = cboNote7;
            cboNotes[8] = cboNote8;
            cboNotes[9] = cboNote9;
            cboNotes[10] = cboNote10;
            cboNotes[11] = cboNote11;
        }

        public void SetMidi(ref MidiOut mOut)
        {
            midiOut = mOut;
        }


        private void ScaleFinderForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                cboNotes[i].Items.Clear();
                cboNotes[i].Items.Add("");
            }

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    cboNotes[i].Items.Add(NoteFreq.NoteNames[j]);
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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            midiOut.AllNotesOff();
            this.Close();
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

        private void cmdFind_Click(object sender, EventArgs e)
        {
            gNumNotes = 0;
            for (int i = 0; i < 12; i++)
            {
                if (cboNotes[i].SelectedIndex > 0)
                {
                    gNotes[gNumNotes] = cboNotes[i].SelectedIndex - 1;
                    gNumNotes++;
                }
            }

            gStartNote = gNotes[0];
            for (int i = 1; i < gNumNotes; i++)
            {
                for(int j = 1; j < gNumNotes; j++)
                {
                    if (gNotes[j] < gNotes[j-1])
                    {
                        gNotes[j] += 12;
                    }
                }
            }
            
            for (int i = 0; i < gNumNotes; i++)
            {
                gIntervals[i] = gNotes[i] - gStartNote;
            }

            string[] scaleList = DBAccess.GetScales(gIntervals, gNumNotes);

            lstScales.Items.Clear();
            txtIntervals.Text = "";
            txtNotes.Text = "";

            if (scaleList.Length > 0)
            {
                for (int i = 0; i < scaleList.Length; i++)
                {
                    lstScales.Items.Add(NoteFreq.NoteNames[gStartNote] + " " + scaleList[i]);
                }

                for (int i = 0; i < gNumNotes; i++)
                {
                    txtIntervals.Text += NoteFreq.IntervalNames[gIntervals[i]] + "\t";
                    txtNotes.Text += NoteFreq.NoteNames[(gIntervals[i] + gStartNote) % 12] + "\t";

                }
                cmdPlay.Enabled = true;
            }
            else
            {
                lstScales.Items.Add("No scales found");
                cmdPlay.Enabled = false;
            }
       }


    }
}
