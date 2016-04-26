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
    public partial class FreqencyTableForm : Form
    {
        MidiOut midiOut = null;

        public FreqencyTableForm()
        {
            InitializeComponent();
        }

        public void SetMidi(ref MidiOut mOut)
        {
            midiOut = mOut;
        }

        private void FreqencyTableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            midiOut.AllNotesOff();
        }

        private void FreqencyTableForm_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = NoteFreq.NoteToFrequency((short)((j * 12)+i)).ToString("#0.00") + "Hz";
                }
                dataGridView1.Rows[i].HeaderCell.Value = NoteFreq.NoteNames[i];
            }
            SetStatus(0, 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            short note = (short)((e.ColumnIndex * 12) + e.RowIndex);
            SetStatus((short)e.RowIndex, note);
            midiOut.AllNotesOff();
            midiOut.NoteOn(0, note, 127);
        }

        private void SetStatus(short row, short note)
        {
            panNote.Text = NoteFreq.NoteNames[row];
            panFreq.Text = Math.Round(NoteFreq.NoteToFrequency(note), 2).ToString() + "Hz";
            
            double wavelength = 1.0 / NoteFreq.NoteToFrequency(note);
            if (wavelength < 0.01)
            {
            panWavelength.Text = wavelength.ToString("#0.00E0") + "m";
            }
            else
            {
                panWavelength.Text = wavelength.ToString("#0.00") + "m";
            }
        }
    }
}
