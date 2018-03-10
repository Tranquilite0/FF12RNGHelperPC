using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF12RNGHelperPC
{
    public class RNG2002 : IRNG
    {
        /// <summary>
        /// This is the seed the FF12:TZA PC uses
        /// </summary>
        public const UInt32 DEFAULT_SEED = 4537U; // 5489U is default seed. PS2 and PS4/FF12:ZA uses 4537.
                                                  //  However TZA PC seems to seed differently with each save load. So seed is irrelevant.

        /* Period parameters */
        public const Int32 N = 624;
        public const Int32 M = 397;
        private const UInt32 MATRIX_A = 0x9908b0dfU;   /* constant vector a */
        private const UInt32 UPPER_MASK = 0x80000000U; /* most significant w-r bits */
        private const UInt32 LOWER_MASK = 0x7fffffffU; /* least significant r bits */

        private UInt32[] mt = new UInt32[N]; /* the array for the state vector  */
        private Int32 mti = N + 1; /* mti==N+1 means mt[N] is not initialized */

        #region Lookahead Buffer
        private List<UInt32[]> LookaheadBuffer;
        private int _minBufferSize = 1;

        public int MinBufferSize
        {
            get
            {
                return _minBufferSize;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("MinBufferSize", "Minimum buffer size cannot be less than 0.");
                }
                else
                {
                    if(value > LookaheadBuffer.Count)
                    {
                        //Add more to the buffer.
                        ExpandBuffer(value - LookaheadBuffer.Count);
                    }
                    _minBufferSize = value;
                }
            }
        }

        private void ExpandBuffer(int count = 1)
        {
            UInt32[] BufferState;
            if(LookaheadBuffer.Count > 0)
            {
                BufferState = LookaheadBuffer.Last();
            }
            else
            {
                BufferState = mt;
            }
            for(int i = 0; i < count; i++)
            {
                BufferState = (UInt32[])BufferState.Clone();
                Twist(BufferState);
                LookaheadBuffer.Add(BufferState);
            }
        }

        private UInt32[] PopBuffer()
        {
            var First = LookaheadBuffer.First();
            LookaheadBuffer.RemoveAt(0);
            if(LookaheadBuffer.Count < MinBufferSize)
            {
                ExpandBuffer();
            }
            return First;
        }
        #endregion

        #region Core Functionality
        public RNG2002(UInt32 seed = DEFAULT_SEED)
        {
            SGenRand(seed);
            LookaheadBuffer = new List<uint[]>(MinBufferSize);
            ExpandBuffer(MinBufferSize);
        }

        public void SGenRand()
        {
            SGenRand(DEFAULT_SEED);
        }

        /* initializes mt[N] with a seed */
        public void SGenRand(UInt32 s) //init_genrand
        {
            mt[0] = s & 0xffffffff;
            for (mti = 1; mti < N; mti++)
            {
                mt[mti] =
                (1812433253U * (mt[mti - 1] ^ (mt[mti - 1] >> 30)) + (UInt32)mti);
                /* See Knuth TAOCP Vol2. 3rd Ed. P.106 for multiplier. */
                /* In the previous versions, MSBs of the seed affect   */
                /* only MSBs of the array mt[].                        */
                /* 2002/01/09 modified by Makoto Matsumoto             */
                mt[mti] &= 0xffffffff;
                /* for >32 bit machines */
            }
        }

        private static readonly UInt32[] mag01 = { 0x0U, MATRIX_A }; //Moved out of below method.
        /* mag01[x] = x * MATRIX_A  for x=0,1 */

        /* generates a random number on [0,0xffffffff]-interval */
        public UInt32 GenRand() //genrand_int32
        {
            if (mti >= N)
            { /* generate N words at one time */

                if (mti == N + 1)   /* if init_genrand() has not been called, */
                    SGenRand(DEFAULT_SEED); /* a default initial seed is used */

                if (LookaheadBuffer.Count > 0)
                {
                    //We already have next set of numbers, so grab those instead.
                    mt = PopBuffer();
                }
                else
                {
                    Twist(mt);
                }

                mti = 0;
                //LookaheadReady = false;
            }
            return Temper(mt[mti++]);
        }

        /// <summary>
        /// Generates a random number on [0,0xffffffff]-interval. Does not advance RNG
        /// Offset allows you to peek N positions ahead in the RNG. Guarenteed to be able to look up to N * MinBufferSize positions ahead with constant complexity. 
        /// Allows looking after that range. May allow looking before that range depending on current RNG state. 
        /// Throws an exception if:
        /// RNG has not been seeded yet.
        /// Offset would cause RNG to peek a negative index.
        /// </summary>
        /// <param name="offset">Number of positions to look forward/backward into the RNG</param>
        /// <returns> RNG value at desired position. </returns>
        public UInt32 PeekRand(int offset = 0) //genrand_int32
        {
            UInt32 y;
            int forwardN = ((mti + offset) / N);
            if (mti + offset < 0)
            {
                throw new ArgumentOutOfRangeException("offset", "mti + offset cannot be negative.");
            }
            else if (mti == N + 1) /* if init_genrand() has not been called, */
            {
                throw new InvalidOperationException("Cannot peek before RNG is seeded.");
            }
            else if (forwardN > LookaheadBuffer.Count)
            {
                //Value needed is outside of our buffer. Expand buffer.
                ExpandBuffer(forwardN - LookaheadBuffer.Count);
            }

            if (forwardN > 0)
            {   /* We need a value in our lookahead buffer */
                y = LookaheadBuffer[forwardN - 1][(mti + offset) % N];
            }
            else
            {
                /* peek next y instead, but dont advance mti*/
                y = mt[mti + offset];
            }

            return Temper(y);
        }

        /// <summary>
        /// Advances the RNG numtoadvance positions into the future
        /// </summary>
        /// <param name="numToAdvance">number of positions to advance</param>
        public void AdvanceRand(int numToAdvance)
        {
            if (numToAdvance < 0)
            {
                throw new ArgumentOutOfRangeException("numtoadvance", "Input cannot be negative.");
            }

            for (int nt = 0; nt < (numToAdvance + mti) / N; nt++)
            {
                if (LookaheadBuffer.Count > 0)
                {
                    //We already have next set of numbers, so grab those instead.
                    mt = PopBuffer();
                }
                else
                {
                    Twist(mt);
                }
            }
            mti = (numToAdvance + mti) % N;
        }

        /// <summary>
        /// Tempering function of the Mersenne Twister.
        /// </summary>
        /// <param name="y">value from the mt state array</param>
        /// <returns>tempered value</returns>
        private static UInt32 Temper(UInt32 y)
        {
            /* Tempering */
            y ^= (y >> 11);
            y ^= (y << 7) & 0x9d2c5680U;
            y ^= (y << 15) & 0xefc60000U;
            y ^= (y >> 18);

            ////Dissasembly of the PC version's ASM reveals the following tempering function
            ////It seems to be equivalent to the reference tempering function though. It is
            ////Included for reference anyway.
            //y ^= (y >> 11);
            //y ^= (y & 0xFF3A58ADU) << 7;
            //y ^= (y & 0xFFFFDF8CU) << 15;
            //y ^= (y >> 18);

            return y;
        }

        /// <summary>
        /// Takes the passed in state array and generates the next 624 numbers in the sequence
        /// </summary>
        private static void Twist(UInt32[] mt)
        {
            UInt32 y;
            int kk;

            for (kk = 0; kk < N - M; kk++)
            {
                y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                mt[kk] = mt[kk + M] ^ (y >> 1) ^ mag01[y & 0x1UL];
            }
            for (; kk < N - 1; kk++)
            {
                y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                mt[kk] = mt[kk + (M - N)] ^ (y >> 1) ^ mag01[y & 0x1U];
            }
            y = (mt[N - 1] & UPPER_MASK) | (mt[0] & LOWER_MASK);
            mt[N - 1] = mt[M - 1] ^ (y >> 1) ^ mag01[y & 0x1U];
        }
        #endregion

        #region State Manipulation
        /// <summary>
        /// Saves the state of the RNG
        /// </summary>
        /// <param name="rng"></param>
        /// <returns>RNGState structure</returns>
        public RNGState SaveState()
        {
            return new RNGState(mti, mt.Clone() as uint[]);
        }

        /// <summary>
        /// Loads the state of the RNG
        /// </summary>
        /// <param name="inmti">Input mti</param>
        /// <param name="inmt">Input mt</param>
        public void LoadState(int mti, UInt32[] mt)
        {
            this.mti = mti;
            mt.CopyTo(this.mt, 0);
            LookaheadBuffer.Clear();
            ExpandBuffer(MinBufferSize);
        }

        /// <summary>
        /// Loads the state of the RNG
        /// </summary>
        /// <param name="inputState">Input state</param>
        public void LoadState(RNGState inputState)
        {
            LoadState(inputState.mti, inputState.mt);
        }

        /// <summary>
        /// Attempts to sync RNG state to external state passed in. Guarenteed to be able to sync with an RNGState N * MinBufferSize positions in the future.
        /// </summary>
        /// <param name="inputState"></param>
        /// <returns>The number of positions in the future the RNG was synced to, or -1 if the RNG state difference could not be determined.</returns>
        public int SyncState(RNGState inputState)
        {
            //Check if inputState is within current mt window.
            if(mt.SequenceEqual(inputState.mt))
            {
                int indexDifference = inputState.mti - mti;
                mti = inputState.mti;
                return indexDifference;
                //May return negative value if input state was from a time "before" current state.
                // I dont feel like differentiating between a loss of sync, and a back-in-time sync.
            }

            //Now check if inputState is within lookahead buffer
            for (int i = 0; i < LookaheadBuffer.Count; i++)
            {
                if (LookaheadBuffer[i].SequenceEqual(inputState.mt))
                {
                    int stateDifference = inputState.mti - mti + (N * (i + 1));
                    LoadState(inputState);
                    return stateDifference;
                }
            }
            //State could not be synced
            LoadState(inputState);
            return -1;
        }
#endregion

    }
}
