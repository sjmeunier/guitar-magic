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
    public partial class MetronomeForm : Form
    {
        private MidiOut midiOut = null;
        private int gBeats;
        private int gTimeDelay;
        private int gCurrentBeat;
        private int gTempo;
        private int gNoteType;

        public MetronomeForm()
        {
            InitializeComponent();
        }

        public void SetMidi(ref MidiOut mOut)
        {
            midiOut = mOut;
        }

        private void MetronomeForm_Load(object sender, EventArgs e)
        {
            txtTopNum.Text = Globals.beatSignature.ToString();
            txtBottomNum.Text = Globals.timeSignature.ToString();
            txtTempo.Text = Globals.defaultTempo.ToString();

            midiOut.ProgramChange(15, 0, Globals.defaultMetronomeSound);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            midiOut.AllNotesOff();
            this.Close();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            midiOut.AllNotesOff();
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
            cmdChange.Enabled = false;
            timer1.Enabled = false;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            cmdStart.Enabled = false;
            cmdStop.Enabled = true;
            cmdChange.Enabled = true;

            gCurrentBeat = 0;
            gBeats = Convert.ToInt32(txtTopNum.Text);
            gTempo = Convert.ToInt32(txtTempo.Text);
            gNoteType = Convert.ToInt32(txtBottomNum.Text);

            gTimeDelay = Convert.ToInt32(1000.0 / ((double)gTempo / 60.0));

           
            lblBottom.Text = gNoteType.ToString().Trim();
            timer1.Interval = gTimeDelay;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gCurrentBeat++;
            if (gCurrentBeat > gBeats)
            {
                gCurrentBeat = 1;
            }

            if (gCurrentBeat == 1)
            {
                lblTop.ForeColor = Color.Red;
                midiOut.NoteOn(15, 38, 127);
            }
            else
            {
                lblTop.ForeColor = Color.Black;
                midiOut.NoteOn(15, 45, 127);
            }
            lblTop.Text = gCurrentBeat.ToString().Trim();
        }

        private void cmdChange_Click(object sender, EventArgs e)
        {
            gBeats = Convert.ToInt32(txtTopNum.Text);
            gTempo = Convert.ToInt32(txtTempo.Text);
            gNoteType = Convert.ToInt32(txtBottomNum.Text);

            gTimeDelay = Convert.ToInt32((((double)gTempo / 60.0) / (double)gBeats) * 1000.0);


            lblBottom.Text = gNoteType.ToString().Trim();
            timer1.Interval = gTimeDelay;
            timer1.Enabled = true;

        }
    }
}
