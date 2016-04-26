namespace MidiLib
{
    public class MidiExceptions
    {
        public const int MMSYSERR_BASE = 0;

        public const int MMSYSERR_ALLOCATED = 4;
        public const int MMSYSERR_BADDB = 14;
        public const int MMSYSERR_BADDEVICEID = 2;
        public const int MMSYSERR_BADERRNUM = 9;
        public const int MMSYSERR_DELETEERROR = 18;
        public const int MMSYSERR_ERROR = 1;
        public const int MMSYSERR_HANDLEBUSY = 12;
        public const int MMSYSERR_INVALFLAG = 10;
        public const int MMSYSERR_INVALHANDLE = 5;
        public const int MMSYSERR_INVALIDALIAS = 13;
        public const int MMSYSERR_INVALPARAM = 11;
        public const int MMSYSERR_KEYNOTFOUND = 15;
        public const int MMSYSERR_LASTERROR = 20;
        public const int MMSYSERR_NODRIVER = 6;
        public const int MMSYSERR_NODRIVERCB = 20;
        public const int MMSYSERR_NOERROR = 0;
        public const int MMSYSERR_NOMEM = 7;
        public const int MMSYSERR_NOTENABLED = 3;
        public const int MMSYSERR_NOTSUPPORTED = 8;
        public const int MMSYSERR_READERROR = 16;
        public const int MMSYSERR_VALNOTFOUND = 19;
        public const int MMSYSERR_WRITEERROR = 17;

        public const int MIDIERR_BASE = 64;

        //  MIDI error return values
        public const int MIDIERR_UNPREPARED = (MIDIERR_BASE + 0);       //  header not prepared
        public const int MIDIERR_STILLPLAYING = (MIDIERR_BASE + 1);     //  still something playing
        public const int MIDIERR_NOMAP = (MIDIERR_BASE + 2);            //  no current map
        public const int MIDIERR_NOTREADY = (MIDIERR_BASE + 3);         //  hardware is still busy
        public const int MIDIERR_NODEVICE = (MIDIERR_BASE + 4);         //  port no longer connected
        public const int MIDIERR_INVALIDSETUP = (MIDIERR_BASE + 5);     //  invalid setup
        public const int MIDIERR_LASTERROR = (MIDIERR_BASE + 5);        //  last error in range

    }
}
