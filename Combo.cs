using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF12RNGHelperPC
{
    public static class Combo
    {
        /// <summary>
        /// How many positions forward in the RNG after starting an attack that a combo is determined. 
        /// </summary>
        public const int ComboDeterminationPosition = 5;

        /// <summary>
        /// Rng values consumed for an unarmed attack (when no combo occurs).
        /// </summary>
        public const int RngConsumedForAttack = 10;

        /// <summary>
        /// Unarmed Combo Chance
        /// </summary>
        private const int ComboChance = 3;

        /// <summary>
        /// Tests if given rng value results in a combo
        /// </summary>
        public static bool DoesCombo(uint prng)
        {
            return (prng % 100) < ComboChance;
        }

        /// <summary>
        /// Tests if a combo reesults from the given IRNG instance and offset
        /// </summary>
        public static bool DoesCombo(IRNG rng, int offset = 0)
        {
            return DoesCombo(rng.PeekRand(offset + ComboDeterminationPosition - 1));
        }
    }
}
