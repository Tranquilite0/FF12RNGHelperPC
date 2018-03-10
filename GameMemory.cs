using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace FF12RNGHelperPC
{
    class FF12PCMemory
    {

        const int PROCESS_WM_READ = 0x0010;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess,
            IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        //public static readonly IntPtr FRAME_COUNTER_OFFSET = new IntPtr(0x01ECD73C); //Not sure if main module base+offset is better...
        public static readonly IntPtr FRAME_COUNTER_ADDR = new IntPtr(0x01FED73C); //...or full address is better.

        public static readonly IntPtr MT_ADDR = new IntPtr(0x02EAC670); //Address of first element of mt, an array of 624 Uint32
        public static readonly IntPtr MTI_ADDR = new IntPtr(0x02EAD030); //Address of mti, an Int32
        private const int INT32_SIZE = 4;
        private const int STATE_BUFFER_SIZE = INT32_SIZE * (RNG2002.N + 1);

        private byte[] rngStateBuffer = new byte[STATE_BUFFER_SIZE]; //Memory buffer large enough to hold state array and state array index of Mersenne Twister RNG.

        private Process _FF12EXE;
        private IntPtr FF12Handle;
        //private IntPtr FF12BaseAddress;


        private const string GAME_NAME = "FFXII_TZA";

        ~FF12PCMemory()
        {
            //I read in the OpenProcess documentation that you should always do this...
            CloseHandle(FF12Handle);
        }

        /// <summary>
        /// Attaches to FF12 Process and opens handle with read priveledges
        /// </summary>
        /// <param name="procName">Process Name</param>
        /// <returns>true if successfully attaches to FF12PC, false if the program could not be found.</returns>
        public bool AttachToProcess(string procName = GAME_NAME)
        {
            //Maybe more sentinels?
            if (_FF12EXE == null || _FF12EXE.HasExited || FF12Handle == IntPtr.Zero)
            {
                _FF12EXE = Process.GetProcessesByName(procName).FirstOrDefault();
                if (_FF12EXE != null)
                {
                    //I read in the OpenProcess documentation that you should always do this...
                    CloseHandle(FF12Handle);
                    //Open Handle to process with Read permissions. Will need to change if memory writing is ever implemented.
                    FF12Handle = OpenProcess(PROCESS_WM_READ, false, _FF12EXE.Id);
                    //FF12BaseAddress = FF12EXE.MainModule.BaseAddress; //Only useful for Base+Offset memory references.
                    return true;
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Reads State of RNG in memory
        /// </summary>
        /// <param name="state"> The RNGState you read from memory.</param>
        /// <returns>true if read successfull, false otherwise.</returns>
        public bool ReadState(out RNGState state)
        {
            //I might even put this in a try-catch block just in case?
            //Really hard to tell what can happen

            if (AttachToProcess())
            {
                int bytesRead = 0;

                //Read RNG state fotunately 
                ReadProcessMemory(FF12Handle, MT_ADDR, rngStateBuffer, rngStateBuffer.Length, ref bytesRead);
                if (bytesRead == STATE_BUFFER_SIZE)
                {
                    Int32 mti = BitConverter.ToInt32(rngStateBuffer, STATE_BUFFER_SIZE - INT32_SIZE);
                    UInt32[] mt = new UInt32[624];
                    //Memory copy shenanigans abound. Fortunately these two arrays are binary compatible
                    Buffer.BlockCopy(rngStateBuffer, 0, mt, 0, STATE_BUFFER_SIZE - INT32_SIZE);
                    state = new RNGState
                    {
                        mt = mt,
                        mti = mti
                    };
                    return true;
                }

            }

            state = new RNGState();
            return false;
        }

    }
}
