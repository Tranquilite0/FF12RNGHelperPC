using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF12RNGHelperPC
{
    class ChestFuture : FutureBase
    {
        private Chest _chest;
        public Chest Chest
        {
            get { return _chest; }
            set
            {
                if (_chest != value)
                {
                    hasCachedFuture = false;
                }
                _chest = value;
            }
        }

        public ChestFuture(ChestResult desiredResult, Chest chestInfo, int searchDepth)
        {
            DesiredResult = desiredResult;
            Chest = chestInfo;
            SearchDepth = searchDepth;
        }

        protected override bool GenerateAndCheckResult(IRNG rng, int offset = 0)
        {
            return this.Chest.CheckChest(rng, offset).SameOrBetter(DesiredResult);
        }

        public int GetSpawnFuture(IRNG rng, int offset = 0)
        {
            //TODO: Consider splitting ChestSpawn into its own class, and make its own future class if lack of caching turns out to be performance issue.
            //No need to implement future sync either because no cached future.
            //Or maybe just put a simple future calculation into the Chest Class?
            for (int i = 0; i < SearchDepth; i++)
            {
                if (this.Chest.CheckSpawn(rng, i + offset))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
