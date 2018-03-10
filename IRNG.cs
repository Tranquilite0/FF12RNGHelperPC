using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF12RNGHelperPC
{
    public interface IRNG //TODO: consider having IRNG implement IEnumerable
    {
        void SGenRand();
        void SGenRand(UInt32 s);
        UInt32 GenRand();
        UInt32 PeekRand(int offset = 0);
        void AdvanceRand(int numtoadvance);
        int MinBufferSize { get; set; }

        RNGState SaveState();
        void LoadState(int inmti, UInt32[] inmt);
        void LoadState(RNGState state);
    }

    /// <summary>
    /// Represents the state of the Mersenne Twister RNG
    /// </summary>
    public struct RNGState
    {
        /// <summary>
        /// Index into the mt state array.
        /// </summary>
        public int mti;

        /// <summary>
        /// The mt state array.
        /// </summary>
        public UInt32[] mt;

        public RNGState(int mti, UInt32[] mt)
        {
            this.mti = mti;
            this.mt = mt;
        }

        public RNGState(RNGState state)
        {
            mti = state.mti;
            mt = state.mt;
        }

        public RNGState DeepCopy()
        {
            RNGState ToReturn = new RNGState();
            ToReturn.mti = mti;
            mt.CopyTo(ToReturn.mt, 0);

            return ToReturn;
        }
    }
}
