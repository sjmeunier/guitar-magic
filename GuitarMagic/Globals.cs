using System;
using System.Collections.Generic;
using System.Text;
using MidiLib;

namespace GuitarMagic
{
    public class Globals
    {
        public static MidiTypes.MidiDevices[] midiDevices;
        public static int defaultDevice = 0;
        public static short defaultInstrument = 0;
        public static GeneralMidiInstrument midiInstruments;
        public static string defaultTuning = "Standard";
        public static int chordCombinations = 0;
        public static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=GuitarMagic.dat;User Id=admin;Password=;";
        public static int defaultTempo = 120;
        public static int beatSignature = 4;
        public static int timeSignature = 4;
        public static int playDelay = 400;
        public static int standardAFrequency = 440;
        public static short defaultMetronomeSound = 117;
        public static int defaultFingerStretch = 4;
        public static int defaultInputDevice = 0;
        public static int inputChannels = 2;
        public static int inputBits = 16;
        public static int inputSampleRate = 11025;
    }
}
