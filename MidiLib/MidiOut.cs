using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;

namespace MidiLib
{
    public class MidiOut
    {

        private int m_hmidiout;



        #region Win32 Midi Device Functions

        [DllImport("winmm.dll")]
        private static extern int midiOutGetNumDevs();

        [DllImport("winmm.dll")]
        private static extern int midiOutGetDevCaps(int uDeviceID, ref MidiTypes.MIDIOUTCAPS midiOutCaps, int uSize);

        [DllImport("winmm.dll")]
        private static extern int midiOutClose(int hMidiOut);

        [DllImport("winmm.dll")]
        private static extern int midiOutGetVolume(int uDeviceID, ref int lpdwVolume);

        [DllImport("winmm.dll")]
        private static extern int midiOutSetVolume(int uDeviceID, int dwVolume);

        [DllImport("winmm.dll")]
        private static extern int midiOutShortMsg(int hMidiOut, int dwMsg);

        [DllImport("winmm.dll")]
        private static extern int midiOutOpen(ref int lphMidiOut, int uDeviceID, int dwCallback, int dwInstance, int dwFlags);

        [DllImport("winmm.dll")]
        private static extern int midiOutGetErrorText(int err, ref string msg, int uSize);

        #endregion

        public void CloseMidiOut()
        {
            int midiError;

            if (m_hmidiout != 0)
            {
                midiError = midiOutClose(m_hmidiout);
                if (midiError != 0)
                {
                    midiOutputError(midiError);
                }
                m_hmidiout = 0;
            }
        }

        public bool OpenMidiOut(int deviceId)
        {
            int midiError;

            CloseMidiOut();
            midiError = midiOutOpen(ref m_hmidiout, deviceId, 0, 0, 0);
            if (midiError != 0)
            {
                midiOutputError(midiError);
            }
            if (m_hmidiout != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MidiOutShort(short b1, short b2, short b3)
        {
            int midiError;

            midiError = midiOutShortMsg(m_hmidiout, PackDWord(b3, b2, b1));
            if (midiError != 0)
            {
                midiOutputError(midiError);
            }
        }

        public int PackDWord(short i1, short i2, short i3)
        {
            int ret = i1 * 0x10000 + i2 * 0x100 + i3;
            return ret;

        }

        public int GetNumberDevices()
        {
            return midiOutGetNumDevs();
        }

        public int GetVolume()
        {
            int volume = 0;
            int midiError;

            midiError = midiOutGetVolume(MidiConst.MIDI_MAPPER, ref volume);
            if (midiError != 0)
            {
                midiOutputError(midiError);
            }
            return volume;
        }

        public void SetVolume(int volume)
        {
            int midiError;

            midiError = midiOutSetVolume(MidiConst.MIDI_MAPPER, volume);
            if (midiError != 0)
            {
                midiOutputError(midiError);
            }
        }

        public void midiOutputError(int midiError)
        {
            string errMsg = "";
            midiOutGetErrorText(midiError, ref errMsg, MidiConst.MAXERRORLENGTH);
            throw new Exception(errMsg);
        }

        public MidiTypes.MidiDevices[] GetOutputDevices()
        {
            MidiTypes.MIDIOUTCAPS midicaps = new MidiTypes.MIDIOUTCAPS();
            MidiTypes.MidiDevices midiDevices = new MidiTypes.MidiDevices();

            ArrayList al = new ArrayList();

            // Test for MIDI mapper
            if (midiOutGetDevCaps(MidiConst.MIDI_MAPPER, ref midicaps, Marshal.SizeOf(midicaps)) == 0)
            {
                midiDevices.deviceId = MidiConst.MIDI_MAPPER;
                midiDevices.deviceName = midicaps.szPname;
                al.Add(midiDevices);
            }
   
            // Add other devs
            for (int i = 0; i < midiOutGetNumDevs(); i++)
            {
                if (midiOutGetDevCaps(i, ref midicaps, Marshal.SizeOf(midicaps)) == 0)
                {

                    midiDevices.deviceId = i;
                    midiDevices.deviceName = midicaps.szPname;
                    al.Add(midiDevices);
                }
            }
            return (MidiTypes.MidiDevices[])al.ToArray(typeof(MidiTypes.MidiDevices));
        }

        public void AllNotesOff()
        {
            for(short channel = 0; channel < 16; channel++)
            {
                MidiOutShort((short)(0xB0 + channel), 0x78, 0);
                MidiOutShort((short)(0xB0 + channel), 0x7B, 0);
            }
        }

        public void AllNotesOff(short channel)
        {
            MidiOutShort((short)(0xB0 + channel), 0x78, 0);
        }

        public void Nibblize(int value, ref short msb, ref short lsb)
        {
            lsb = (short)(value & 0x7f);
            value = value & 0x7f80;
            msb = (short)(value / 128);
        }

        public void bender(short channel, int value)
        {
            short msb = 0;
            short lsb = 0;

            Nibblize(value, ref msb, ref lsb);
            MidiOutShort((short)(0xe0 + channel), lsb, msb);
        }

        public void ControlChange(short channel, short ccnr, short v)
        {
            MidiOutShort((short)(0xb0 + channel), ccnr, v);
        }

        public void MidiSetRPN(short channel, short pmsb, short plsb, short msb, short lsb)
        {
            MidiOutShort(channel, 0x65, pmsb);
            MidiOutShort(channel, 0x64, plsb);
            MidiOutShort(channel, 0x6, msb);
            MidiOutShort(channel, 0x26, lsb);
        }

        public void NoteOff(short channel, short kk)
        {
            MidiOutShort((short)(0x90 + channel), kk, 0);
        }

        public void NoteOn(short channel, short kk, short v)
        {
            MidiOutShort((short)(0x90 + channel), kk, v);
        }

        public void PitchBend(short channel, short l, short m)
        {
            MidiOutShort((short)(0xe0 + channel), l, m);
        }

        public void ProgramChange(short channel, short cc0nr, short pnr)
        {
            ControlChange(channel, 0, cc0nr);
            MidiOutShort((short)(0xc0 + channel), pnr, 0);
        }

        public void ResetControllers()
        {
            for (int channel = 0; channel < 16; channel++)
            {
                MidiOutShort((short)(0xb0 + channel), 0x79, 0);
            }
        }

    }
}
