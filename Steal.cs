namespace FF12RNGHelperPC
{
    /// <summary>
    /// This class encapsulates the logic of the steal command
    /// </summary>
    static class Steal
    {
        // Steal chances
        private const int CommonChance = 55;
        private const int UncommonChance = 10;
        private const int RareChance = 3;
        private const int CommonChanceCuffs = 80;
        private const int UncommonChanceCuffs = 30;
        private const int RareChanceCuffs = 6;

        /// <summary>
        /// Check if you steal anything while not wearing the Thief's Cuffs
        /// When not wearing Thief's Cuffs you may only steal one item.
        /// Once you are successful, you get that item and that's it.
        /// </summary>
        /// <param name="prng1">prng value used to check rare steal.</param>
        /// <param name="prng2">prng value used to check uncommon steal</param>
        /// <param name="prng3">prng value used to check common steal</param>
        /// <returns>The result of your steal command.</returns>
        public static StealResult CheckSteal(uint prng1, uint prng2, uint prng3)
        {
            if (StealSuccessful(prng1, RareChance))
            {
                return new StealResult(true, false, false);
            }
            if (StealSuccessful(prng2, UncommonChance))
            {
                return new StealResult(false, true, false);
            }
            if (StealSuccessful(prng3, CommonChance))
            {
                return new StealResult(false, false, true);
            }
            return new StealResult(false, false, false);
        }

        /// <summary>
        /// Check steal using instance of IRNG. Does not modify state of RNG.
        /// </summary>
        /// <param name="rng">IRNG instance to check against</param>
        /// <param name="offset">Position in RNG to check</param>
        /// <param name="cuffs">Whether you have cuffs</param>
        /// <returns>The result of your steal command.</returns>
        public static StealResult CheckSteal(IRNG rng, int offset, bool cuffs = false)
        {
            return CheckSteal(rng.PeekRand(offset + 0), rng.PeekRand(offset + 1), rng.PeekRand(offset + 2), cuffs);
        }

        /// <summary>
        /// Like the other CheckSteal methods, but you get to choose if you have cuffs.
        /// </summary>
        public static StealResult CheckSteal(uint prng1, uint prng2, uint prng3, bool cuffs)
        {
            if (cuffs)
            {
                return CheckStealCuffs(prng1, prng2, prng3);
            }
            else return CheckSteal(prng1, prng2, prng3);
        }

        /// <summary>
        /// Check if you steal anything while wearing the Thief's Cuffs
        /// When not wearing Thief's Cuffs you may steal more than one
        /// item, and you have better odds. Roll against all 3 and get
        /// everything you successfully steal.
        /// </summary>
        /// <param name="prng1">prng value used to check rare steal.</param>
        /// <param name="prng2">prng value used to check uncommon steal</param>
        /// <param name="prng3">prng value used to check common steal</param>
        /// <returns>The result of your steal command.</returns>
        public static StealResult CheckStealCuffs(uint prng1, uint prng2, uint prng3)
        {
            bool Rare = false, Uncommon = false, Common = false;

            if (StealSuccessful(prng1, RareChanceCuffs))
            {
                Rare = true;
            }
            if (StealSuccessful(prng2, UncommonChanceCuffs))
            {
                Uncommon = true;
            }
            if (StealSuccessful(prng3, CommonChanceCuffs))
            {
                Common = true;
            }

            return new StealResult(Rare, Uncommon, Common);
        }

        /// <summary>
        /// Like other CheckSteal overloads, with IRNG and offset parameters, assuming thieves cuffs.
        /// </summary>

        public static StealResult CheckStealCuffs(IRNG rng, int offset)
        {
            return CheckSteal(rng, offset, true);
        }

        /// <summary>
        /// Calculate if a steal attempt was successful
        /// </summary>
        private static bool StealSuccessful(uint prng, int chance)
        {
            return RandToPercent(prng) < chance;
        }

        /// <summary>
        /// Convert an RNG value into a percentage
        /// </summary>
        private static int RandToPercent(uint toConvert)
        {
            return (int)(toConvert % 100);
        }
    }
}
