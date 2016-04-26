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
    public partial class TransposerForm : Form
    {
        public TransposerForm()
        {
            InitializeComponent();
        }

        private void TransposerForm_Load(object sender, EventArgs e)
        {
            cboOriginalKey.Items.Clear();
            cboTransposedKey.Items.Clear();
            for (int i = 0; i < NoteFreq.NoteNames.Length; i++)
            {
                cboOriginalKey.Items.Add(NoteFreq.NoteNames[i]);
                cboTransposedKey.Items.Add(NoteFreq.NoteNames[i]);
            }
            cboOriginalKey.SelectedIndex = 0;
            cboTransposedKey.SelectedIndex = 0;

            cboScale.Items.Clear();

            string[] scaleNameList = DBAccess.GetAllScaleNames();
            for (int i = 0; i < scaleNameList.Length; i++)
            {
                cboScale.Items.Add(scaleNameList[i]);
            }
            cboScale.SelectedIndex = 0;
        }

        private void cmdTranspose_Click(object sender, EventArgs e)
        {
            string scaleName = cboScale.SelectedItem.ToString();
            int[] intervals = DBAccess.GetScaleIntervals(scaleName);
            int originalKey = cboOriginalKey.SelectedIndex;
            int transposedKey = cboTransposedKey.SelectedIndex;

            string originalScaleText = "";
            string transposedScaleText = "";
            string intervalsText = "";

            for (int i = 0; i < intervals.Length; i++)
            {
                originalScaleText += NoteFreq.NoteNames[(intervals[i] + originalKey) % 12] + "\t";
                transposedScaleText += NoteFreq.NoteNames[(intervals[i] + transposedKey) % 12] + "\t";
                intervalsText += NoteFreq.IntervalNames[intervals[i]] + "\t";
            }

            txtOriginalScale.Text = originalScaleText;
            txtTransposedScale.Text = transposedScaleText;
            txtIntervals.Text = intervalsText;
            txtScale.Text = scaleName;

        }
    }
}
