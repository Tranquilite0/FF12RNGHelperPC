using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF12RNGHelperPC
{
    public class StealFuture : FutureBase
    {
        private bool _cuffs;
        public bool Cuffs
        {
            get { return _cuffs; }
            set
            {
                if(_cuffs != value)
                {
                    hasCachedFuture = false;
                }
                _cuffs = value;
            }
        }

        protected override bool GenerateAndCheckResult(IRNG rng, int offset = 0)
        {
            return Steal.CheckSteal(rng, offset, Cuffs).SameOrBetter(DesiredResult);
        }

        public StealFuture(StealResult desiredSteal, bool cuffs, int searchDepth)
        {
            this.DesiredResult = desiredSteal;
            this.SearchDepth = searchDepth;
            this.Cuffs = cuffs;

        }

    }
}
