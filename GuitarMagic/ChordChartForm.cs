using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MidiLib;

namespace GuitarMagic
{
    public partial class ChordChartForm : Form
    {
        private MidiOut midiOut = null;
        private int[] gTuningNotes = new int[6];
        private int gCurrentChord = 0;
        ArrayList gChordList = new ArrayList();
        private bool gotoLoaded = false;
        private int gPlayNote = 0;
        private int[] gNotes;

        public ChordChartForm()
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


        private void ChordChartForm_Load(object sender, EventArgs e)
        {
            cboRoot.Items.Clear();
            for (int i = 0; i < NoteFreq.NoteNames.Length; i++)
            {
                cboRoot.Items.Add(NoteFreq.NoteNames[i]);
            }
            cboRoot.SelectedIndex = 0;
            cboChordType.Items.Clear();

            string[] chordNameList = DBAccess.GetAllShortChordNames();
            for (int i = 0; i < chordNameList.Length; i++)
            {
                cboChordType.Items.Add(chordNameList[i]);
            }
            cboChordType.SelectedIndex = 0;

            string[] tuningNameList = DBAccess.GetAllTuningNames();
            for (int i = 0; i < tuningNameList.Length; i++)
            {
                cboTuning.Items.Add(tuningNameList[i]);
            }
            cboTuning.SelectedIndex = 0;
            cboFingerStretch.SelectedItem = Globals.defaultFingerStretch;

            cboFingerStretch.SelectedIndex = 1;
            cboFromFret.SelectedIndex = 0;
            cboToFret.SelectedIndex = cboToFret.Items.Count - 1;
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

        private void cmdFind_Click(object sender, EventArgs e)
        {
            string longName = DBAccess.GetLongChordName(cboChordType.SelectedItem.ToString());
            gNotes = DBAccess.GetChordNotes(cboRoot.SelectedIndex, longName);

            string noteText = "";
            string intervalText = "";
            SetTuning(cboTuning.SelectedItem.ToString());
            for (int i = 0; i < gNotes.Length; i++)
            {
                noteText += NoteFreq.NoteNames[gNotes[i]] + "\t";
                intervalText += NoteFreq.IntervalNames[gNotes[i]] + "\t";
            }

            txtNotes.Text = noteText;
            txtIntervals.Text = intervalText;
            txtChord.Text = NoteFreq.NoteNames[cboRoot.SelectedIndex] + " " + longName;

            gChordList.Clear();
            gChordList = GetChordList(Convert.ToInt32(cboFromFret.SelectedItem.ToString()), Convert.ToInt32(cboToFret.SelectedItem.ToString()), Convert.ToInt32(cboFingerStretch.SelectedItem.ToString()), gNotes);

            cmdNext.Enabled = false;
            cmdPrev.Enabled = false;
            cmdFirst.Enabled = false;
            cmdLast.Enabled = false;
            cboGoto.Enabled = false;
            cmdPlay.Enabled = true;

            fretBoard1.HideFretPoints();
            if (gChordList.Count > 0)
            {
                gCurrentChord = 1;
                lblStatus.Text = "Chord " + gCurrentChord.ToString() + " of " + gChordList.Count.ToString();

                for (int i = 0; i < 6; i++)
                {
                    if (((int[])gChordList[gCurrentChord - 1])[i] >= 0)
                    {
                        fretBoard1.fretPoints[i, ((int[])gChordList[gCurrentChord - 1])[i]].Visible = true;
                    }
                }
                if (gChordList.Count > 1)
                {
                    cmdNext.Enabled = true;
                    cmdLast.Enabled = true;

                    gotoLoaded = false;
                    cboGoto.Items.Clear();
                    for (int i = 1; i <= gChordList.Count; i++)
                    {
                        cboGoto.Items.Add(i.ToString().Trim());
                    }
                    cboGoto.SelectedIndex = 0;
                    cboGoto.Enabled = true;
                    gotoLoaded = true;
                }
            }


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

        private ArrayList GetChordList(int firstFret, int lastFret, int fingerStretch, int[] chordNotes)
        {
            ArrayList chordList = new ArrayList();
            int minPos = 0;
            int maxPos = 0;
            int startFret = 0;
            int endFret = 0;
            int[] tempChord = new int[6];

            if ((Globals.chordCombinations == 0) || (Globals.chordCombinations == 1))
            {
                for (int h = 0; h < 5; h++)
                {
                    for (int i = firstFret; i <= lastFret; i++)
                    {
                        for (int j = 0; j < (h - 1); j++)
                        {
                            tempChord[j] = -1;
                        }
                        tempChord[h] = i;
                        if (InArray(((gTuningNotes[h] + tempChord[h]) % 12), chordNotes) == true)
                        {
                            minPos = i;
                            maxPos = i;
                            if ((maxPos - fingerStretch) < firstFret)
                            {
                                startFret = firstFret;
                            }
                            else
                            {
                                startFret = maxPos - fingerStretch;
                            }
                            endFret = minPos + fingerStretch;
                            if (endFret > lastFret)
                            {
                                endFret = lastFret;
                            }
                            LoopStrings(firstFret, lastFret, fingerStretch, startFret, endFret, minPos, maxPos, tempChord, h + 1, chordNotes, ref chordList);
                        }
                    }
                }
            }
            else
            {
                for (int i = firstFret; i < lastFret + 1; i++)
                {
                    tempChord[0] = i;
                    if (InArray(((gTuningNotes[0] + tempChord[0]) % 12), chordNotes) == true)
                    {
                        minPos = i;
                        maxPos = i;
                        if ((maxPos - fingerStretch) < firstFret)
                        {
                            startFret = firstFret;
                        }
                        else
                        {
                            startFret = maxPos - fingerStretch;
                        }
                        endFret = minPos + fingerStretch;
                        if (endFret > lastFret)
                        {
                            endFret = lastFret;
                        }
                        LoopStrings(firstFret, lastFret, fingerStretch, startFret, endFret, minPos, maxPos, tempChord, 1, chordNotes, ref chordList);
                    }

                }
            }

            return chordList;
        }

        private void LoopStrings(int firstFret, int lastFret, int fingerStretch, int oldStart, int oldEnd, int oldMin, int oldMax, int[] tempChord, int iteration, int[] chordNotes, ref ArrayList chordList)
        {
            int minPos = 0;
            int maxPos = 0;
            int startFret = 0;
            int endFret = 0;

            if (iteration == 6)
            {
                if (ChordOK(tempChord, chordNotes) == true)
                {
                    int[] tmp = new int[6];
                    for (int i = 0; i < 6; i++)
                    {
                        tmp[i] = tempChord[i];
                    }
                    chordList.Add(tmp);
                    return;
                }
            }
            else
            {
                if (oldStart > 0)
                {
                    tempChord[iteration] = 0;
                    if (InArray(((gTuningNotes[iteration] + tempChord[iteration]) % 12), chordNotes) == true)
                    {
                        minPos = oldMin;
                        maxPos = oldMax;
                        if ((maxPos - fingerStretch) < firstFret)
                        {
                            startFret = firstFret;
                        }
                        else
                        {
                            startFret = maxPos - fingerStretch;
                        }
                        endFret = minPos + fingerStretch;
                        if (endFret > lastFret)
                        {
                            endFret = lastFret;
                        }
                        LoopStrings(firstFret, lastFret, fingerStretch, startFret, endFret, minPos, maxPos, tempChord, iteration + 1, chordNotes, ref chordList);
                    }

                }
                for (int i = oldStart; i <= oldEnd; i++)
                {
                    tempChord[iteration] = i;
                    if (InArray(((gTuningNotes[iteration] + tempChord[iteration]) % 12), chordNotes) == true)
                    {
                        if (i < oldMin)
                        {
                            minPos = i;
                        }
                        else
                        {
                            minPos = oldMin;
                        }
                        if (i > oldMax)
                        {
                            maxPos = i;
                        }
                        else
                        {
                            maxPos = oldMin;
                        }

                        if ((maxPos - fingerStretch) < firstFret)
                        {
                            startFret = firstFret;
                        }
                        else
                        {
                            startFret = maxPos - fingerStretch;
                        }
                        endFret = minPos + fingerStretch;
                        if (endFret > lastFret)
                        {
                            endFret = lastFret;
                        }
                        LoopStrings(firstFret, lastFret, fingerStretch, startFret, endFret, minPos, maxPos, tempChord, iteration + 1, chordNotes, ref chordList);
                    }
                }
                if (Globals.chordCombinations == 0)
                {
                    tempChord[iteration] = -1;
                    LoopStrings(firstFret, lastFret, fingerStretch, oldStart, oldEnd, oldMin, oldMax, tempChord, iteration + 1, chordNotes, ref chordList);
                }
                else if (Globals.chordCombinations == 1)
                {
                    for (int j = iteration; j < 6; j++)
                    {
                        tempChord[j] = -1;
                    }
                    LoopStrings(firstFret, lastFret, fingerStretch, oldStart, oldEnd, oldMin, oldMax, tempChord, 6, chordNotes, ref chordList);
                }
            }
        }

        private bool ChordOK(int[] testChord, int[] chordNotes)
        {
            bool found = false;
            for (int i = 0; i < chordNotes.Length; i++)
            {
                found = false;
                for (int j = 0; j < testChord.Length; j++)
                {
                    if (chordNotes[i] == ((gTuningNotes[j] + testChord[j]) % 12))
                    {
                        found = true;
                    }
                }
                if (found == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            cmdPrev.Enabled = true;
            cmdFirst.Enabled = true;
            gCurrentChord++;

            if (gCurrentChord == gChordList.Count)
            {
                cmdNext.Enabled = false;
                cmdLast.Enabled = false;
            }
            fretBoard1.HideFretPoints();
            lblStatus.Text = "Chord " + gCurrentChord.ToString() + " of " + gChordList.Count.ToString();

            for (int i = 0; i < 6; i++)
            {
                if (((int[])gChordList[gCurrentChord - 1])[i] >= 0)
                {
                    fretBoard1.fretPoints[i, ((int[])gChordList[gCurrentChord - 1])[i]].Visible = true;
                }
            }
        }

        private void cmdPrev_Click(object sender, EventArgs e)
        {
            cmdNext.Enabled = true;
            cmdLast.Enabled = true;
            gCurrentChord--;
            if (gCurrentChord == 1)
            {
                cmdPrev.Enabled = false;
                cmdFirst.Enabled = false;
            }
            fretBoard1.HideFretPoints();
            lblStatus.Text = "Chord " + gCurrentChord.ToString() + " of " + gChordList.Count.ToString();

            for (int i = 0; i < 6; i++)
            {
                if (((int[])gChordList[gCurrentChord - 1])[i] >= 0)
                {
                    fretBoard1.fretPoints[i, ((int[])gChordList[gCurrentChord - 1])[i]].Visible = true;
                }
            }

        }

        private void cmdLast_Click(object sender, EventArgs e)
        {
            cmdPrev.Enabled = true;
            cmdFirst.Enabled = true;
            gCurrentChord = gChordList.Count;

            cmdNext.Enabled = false;
            cmdLast.Enabled = false;
            fretBoard1.HideFretPoints();
            lblStatus.Text = "Chord " + gCurrentChord.ToString() + " of " + gChordList.Count.ToString();

            for (int i = 0; i < 6; i++)
            {
                if (((int[])gChordList[gCurrentChord - 1])[i] >= 0)
                {
                    fretBoard1.fretPoints[i, ((int[])gChordList[gCurrentChord - 1])[i]].Visible = true;
                }
            }
        }

        private void cmdFirst_Click(object sender, EventArgs e)
        {
            cmdNext.Enabled = true;
            cmdLast.Enabled = true;

            gCurrentChord = 1;
            cmdPrev.Enabled = false;
            cmdFirst.Enabled = false;

            fretBoard1.HideFretPoints();
            lblStatus.Text = "Chord " + gCurrentChord.ToString() + " of " + gChordList.Count.ToString();

            for (int i = 0; i < 6; i++)
            {
                if (((int[])gChordList[gCurrentChord - 1])[i] >= 0)
                {
                    fretBoard1.fretPoints[i, ((int[])gChordList[gCurrentChord - 1])[i]].Visible = true;
                }
            }
        }

        private void cboGoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gotoLoaded == true)
            {
                gCurrentChord = Convert.ToInt32(cboGoto.SelectedItem.ToString());

                if (gCurrentChord < gChordList.Count)
                {
                    cmdNext.Enabled = true;
                    cmdLast.Enabled = true;
                }
                else
                {
                    cmdNext.Enabled = false;
                    cmdLast.Enabled = false;
                }
                if (gCurrentChord > 1)
                {
                    cmdPrev.Enabled = true;
                    cmdFirst.Enabled = true;
                }
                else
                {
                    cmdPrev.Enabled = false;
                    cmdFirst.Enabled = false;
                }
                if (gChordList.Count == 1)
                {
                    cmdNext.Enabled = false;
                    cmdLast.Enabled = false;
                }

                fretBoard1.HideFretPoints();
                lblStatus.Text = "Chord " + gCurrentChord.ToString() + " of " + gChordList.Count.ToString();

                for (int i = 0; i < 6; i++)
                {
                    if (((int[])gChordList[gCurrentChord - 1])[i] >= 0)
                    {
                        fretBoard1.fretPoints[i, ((int[])gChordList[gCurrentChord - 1])[i]].Visible = true;
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
