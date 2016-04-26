namespace MidiLib
{
    public class MidiConst
    {
        //  general constants
        public const int MAXPNAMELEN = 32;           //  max product name length (including NULL)
        public const int MAXERRORLENGTH = 128;       //  max error text length (including NULL)


        public const int MM_MIM_OPEN = 0x3C1;                    //  MIDI input
        public const int MM_MIM_CLOSE = 0x3C2;
        public const int MM_MIM_DATA = 0x3C3;
        public const int MM_MIM_LONGDATA = 0x3C4;
        public const int MM_MIM_ERROR = 0x3C5;
        public const int MM_MIM_LONGERROR = 0x3C6;

        public const int MM_MOM_OPEN = 0x3C7;                    //  MIDI output
        public const int MM_MOM_CLOSE = 0x3C8;
        public const int MM_MOM_DONE = 0x3C9;

        public const int MIDIPATCHSIZE = 128;

        //  MIDI callback messages
        public const int MIM_OPEN = MM_MIM_OPEN;
        public const int MIM_CLOSE = MM_MIM_CLOSE;
        public const int MIM_DATA = MM_MIM_DATA;
        public const int MIM_LONGDATA = MM_MIM_LONGDATA;
        public const int MIM_ERROR = MM_MIM_ERROR;
        public const int MIM_LONGERROR = MM_MIM_LONGERROR;
        public const int MOM_OPEN = MM_MOM_OPEN;
        public const int MOM_CLOSE = MM_MOM_CLOSE;
        public const int MOM_DONE = MM_MOM_DONE;

        // device ID for MIDI mapper
        public const int MIDI_MAPPER = (-1);

        //  flags for wFlags parm of midiOutCachePatches(), midiOutCacheDrumPatches()
        public const int MIDI_CACHE_ALL = 1;
        public const int MIDI_CACHE_BESTFIT = 2;
        public const int MIDI_CACHE_QUERY = 3;
        public const int MIDI_UNCACHE = 4;
        //  flags for wTechnology field of MIDIOUTCAPS structure
        public const int MOD_MIDIPORT = 1;      //  output port
        public const int MOD_SYNTH = 2;         //  generic internal synth
        public const int MOD_SQSYNTH = 3;       //  square wave internal synth
        public const int MOD_FMSYNTH = 4;       //  FM internal synth
        public const int MOD_MAPPER = 5;        //  MIDI mapper

        //  flags for dwSupport field of MIDIOUTCAPS structure
        public const int MIDICAPS_VOLUME = 0x1;               //  supports volume control
        public const int MIDICAPS_LRVOLUME = 0x2;             //  separate left-right volume control
        public const int MIDICAPS_CACHE = 0x4;
        //  flags for dwFlags field of MIDIHDR structure
        public const int MHDR_DONE = 0x1;                     //  done bit
        public const int MHDR_PREPARED = 0x2;                 //  set if header prepared
        public const int MHDR_INQUEUE = 0x4;                  //  reserved for driver

    }
}
