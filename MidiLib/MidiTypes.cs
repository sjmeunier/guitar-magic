using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace MidiLib
{
    public class MidiTypes
    {
        //  MIDI output device capabilities structure
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct MIDIINCAPS
        {
            public int wMid;                  //  manufacturer ID
            public int wPid;                  //  product ID
            public int vDriverVersion;        //  version of the driver
            public fixed char szPname[32];    //  product name (NULL terminated string)
        }


        // MIDI output device capabilities structure
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct MIDIOUTCAPS
        {
            public short wMid;                // Manufacturer ID
            public short wPid;                // Product ID
            public int vDriverVersion;     // Driver version

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szPname;  // Product name (NULL terminated string)

            public short wTechnology;         // Device type
            public short wVoices;             // n. of voices (internal synth only)
            public short wNotes;              // max n. of notes (internal synth only)
            public short wChannelMask;        // n. of Midi channels (internal synth only)
            public int dwSupport;          // Supported extra controllers (volume, etc)
        }

        // MIDI data block header
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct MIDIHDR
        {
            public string lpData;            //  pointer to locked data block
            public long dwBufferLength;      //  length of data in data block
            public long dwBytesRecorded;     // used for input only
            public long dwUser;              //  for client's use
            public long dwFlags;             //  assorted flags (see defines)
            public long lpNext;              //  reserved for driver
            public long Reserved;            //  reserved for driver
        }

        public struct MidiDevices
        {
            public int deviceId;
            public string deviceName;
        }

    }
}
