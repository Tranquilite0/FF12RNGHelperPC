using System.Linq;

namespace FF12RNGHelperPC
{
    /// <summary>
    /// A good base to build your future. Implements Future caching to minimize iterating through the RNG.
    /// </summary>
    public abstract class FutureBase : IFuture
    {
        protected bool hasCachedFuture = false;
        protected RNGState CachedState;
        protected int CachedOffset = -1;
        protected int CachedFuture = -1;

        protected IResult _desiredResult;
        public virtual IResult DesiredResult
        {
            get { return _desiredResult; }
            set
            {
                if(_desiredResult == null || !_desiredResult.Same(value))
                {
                    hasCachedFuture = false;
                }
                _desiredResult = value;
            }
        }

        protected int _searchDepth;
        public virtual int SearchDepth
        {
            get { return _searchDepth; }
            set
            {
                _searchDepth = value;
                if (hasCachedFuture && CachedFuture < 0)
                {
                    hasCachedFuture = false;
                }
            }
        }

        /// <summary>
        /// I currently dont have an interface for generating results, so you must generate your own result to check against desiredresult.
        /// </summary>
        /// <returns>Wether or not the generated result matches DesiredResult</returns>
        protected abstract bool GenerateAndCheckResult(IRNG rng, int offset = 0);

        /// <summary>
        /// Determines number of positions to advance RNG to get DesiredResult
        /// </summary>
        /// <returns>Number of positions to advance RNG, or -1 if desired result could not be found in search depth.</returns>
        public virtual int GetFuture(IRNG rng, int offset = 0)
        {
            var state = rng.SaveState();
            if (hasCachedFuture && offset == CachedOffset && state.mti == CachedState.mti && state.mt.SequenceEqual(CachedState.mt))
            {
                return CachedFuture;
            }

            hasCachedFuture = true;
            CachedState = state;
            CachedOffset = offset;

            for (int i = 0; i < SearchDepth; i++)
            {
                if (GenerateAndCheckResult(rng, i + offset))
                {
                    return CachedFuture = i;
                }
            }

            return CachedFuture = -1;
        }

        /// <summary>
        /// Attempts to move existing Future syncAmount positions further.
        /// </summary>
        /// <returns>Updated future</returns>
        public virtual int SyncFuture(int syncAmount, IRNG rng, int offset = 0)
        {
            var state = rng.SaveState();
            //Check if cached future is still good to advance without searching again.
            if (hasCachedFuture && CachedFuture - syncAmount >= 0)
            {
                CachedState = state;
                CachedOffset = offset;
                return CachedFuture -= syncAmount;
            }
            else
            {
                hasCachedFuture = false;
                return GetFuture(rng, offset);
            }
        }
    }
}
