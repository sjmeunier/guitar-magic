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
    public partial class IntervalFinderForm : Form
    {
        private TextBox[] txtIntervals = new TextBox[12];
        private Label[] lblIntervals = new Label[12];
        private int startingNote = 0;

        public IntervalFinderForm()
        {
            InitializeComponent();

            txtIntervals[0] = txtInterval0;
            txtIntervals[1] = txtInterval1;
            txtIntervals[2] = txtInterval2;
            txtIntervals[3] = txtInterval3;
            txtIntervals[4] = txtInterval4;
            txtIntervals[5] = txtInterval5;
            txtIntervals[6] = txtInterval6;
            txtIntervals[7] = txtInterval7;
            txtIntervals[8] = txtInterval8;
            txtIntervals[9] = txtInterval9;
            txtIntervals[10] = txtInterval10;
            txtIntervals[11] = txtInterval11;

            lblIntervals[0] = lblInterval0;
            lblIntervals[1] = lblInterval1;
            lblIntervals[2] = lblInterval2;
            lblIntervals[3] = lblInterval3;
            lblIntervals[4] = lblInterval4;
            lblIntervals[5] = lblInterval5;
            lblIntervals[6] = lblInterval6;
            lblIntervals[7] = lblInterval7;
            lblIntervals[8] = lblInterval8;
            lblIntervals[9] = lblInterval9;
            lblIntervals[10] = lblInterval10;
            lblIntervals[11] = lblInterval11;
        }

        private void IntervalFinderForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                lblIntervals[i].Text = NoteFreq.IntervalNames[i];
            }
            DisplayIntervals();
        }

        private void DisplayIntervals()
        {
            for (int i = 0; i < 12; i++)
            {
                txtIntervals[i].Text = NoteFreq.NoteNames[(i + startingNote) % 12];
            }
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            startingNote++;
            if (startingNote >= 12)
            {
                startingNote = 0;
            }

            DisplayIntervals();
        }

        private void cmdPrev_Click(object sender, EventArgs e)
        {
            startingNote--;
            if (startingNote < 0)
            {
                startingNote = 11;
            }
            DisplayIntervals();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
