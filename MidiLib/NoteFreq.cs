using System;
using System.Collections.Generic;
using System.Text;

namespace MidiLib
{
    public class NoteFreq
    {
        public readonly static string[] NoteNames = { "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B" };
        public readonly static string[] IntervalNames = { "Root", "b2/b9", "2/9", "b3/#9", "3", "4/11", "b5/#11", "5", "#5/b13", "6/13", "b7", "7" };
        private static double[] FrequencyTable = new double[128];

        static NoteFreq()
        {
            SetFrequencies(440);
        }

        public static void SetFrequencies(int referenceFrequency)
        {
            int notesPerOctave = 12;            
            int referenceNoteID = 69;

            double exponent;

            for(int i = 0; i < FrequencyTable.Length; i++)
            {
                exponent = (double)(i - referenceNoteID) / notesPerOctave;

                FrequencyTable[i] = referenceFrequency * Math.Pow(2.0, exponent);
            }
        }

        public static double NoteToFrequency(short note)
        {
            if (note < 0 || note > 127)
            {
                throw new ArgumentOutOfRangeException("Note out of range.");
            }

            return FrequencyTable[note];
        }

        public static short FrequencyToNote(double frequency)
        {
            short note = 0;
            bool found = false;
            
            // Search for the note with a frequency near the specified frequency.
            for (short i = 0; i < 127 && !found; i++)
            {
                note = i;

                // If the specified frequency is less than the frequency of 
                // the next note.
                if (frequency < NoteToFrequency((short)(note + 1)))
                {
                    // Indicate that the note ID for the specified frequency 
                    // has been found.
                    found = true;
                }
            }

            // If the note is not the first or last note, narrow the results.
            if (note > 0 && note < 127)
            {
                // Get the frequency of the previous note.
                double previousFrequncy = NoteToFrequency((short)(note));
                // Get the frequency of the next note.
                double nextFrequency = NoteToFrequency((short)(note + 1));

                // If the next note is closer in frequency than the previous note.
                if (nextFrequency - frequency < frequency - previousFrequncy)
                {
                    // Move to the next note.
                    note++;
                }
            }

            return note;
        }

    }
}
