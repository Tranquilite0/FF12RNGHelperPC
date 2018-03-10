using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace FF12RNGHelperPC
{

    public struct Chest
    {
        //Object currently immutable to make caching futures easier. Will consider changing later.
        //I'm not sure if chest spawn belongs in this class...
        /// <summary>
        /// Chance that the chest will appear.
        /// </summary>
        public readonly int SpawnChance;
        /// <summary>
        /// Positions in future that spawn chance is calculated
        /// </summary>
        public readonly int SpawnPosition;
        /// <summary>
        /// Chance that chest will contain gil
        /// </summary>
        public readonly int GilChance;
        /// <summary>
        /// Chance of getting Item 1. Typically 50% without diamond armlet and 90/95% with diamond armlet for vanilla/zodiac respectively.
        /// </summary>
        public readonly int ItemChance;
        /// <summary>
        /// Maximum amount of gil you can get from the chest.
        /// </summary>
        public readonly int MaxGilAmount;

        public Chest(int spawnChance = 0, int spawnPosition = 0, int gilChance = 0, int itemChance = 0, int maxGilAmount = 0)
        {
            SpawnChance   = spawnChance;
            SpawnPosition = spawnPosition;
            GilChance     = gilChance;
            ItemChance    = itemChance;
            MaxGilAmount  = maxGilAmount;
        }

        public Chest(string spawnChance, string spawnPosition, string gilChance, string itemChance, string maxGilAmount)
        {
            int.TryParse(spawnChance, out SpawnChance);
            int.TryParse(spawnPosition, out SpawnPosition);
            int.TryParse(gilChance, out GilChance);
            int.TryParse(itemChance, out ItemChance);
            int.TryParse(maxGilAmount, out MaxGilAmount);
        }

        public Chest(Chest other)
        {
            this.SpawnChance   = other.SpawnChance;
            this.SpawnPosition = other.SpawnPosition;
            this.GilChance     = other.GilChance;
            this.ItemChance    = other.ItemChance;
            this.MaxGilAmount  = other.MaxGilAmount;
        }

        /// <summary>
        /// Check to see if chest spawned SpawnPosition + offset positions away.
        /// </summary>
        /// <param name="rng">RNG instance to check against</param>
        /// <param name="offset">Offset to use as start</param>
        public bool CheckSpawn(IRNG rng, int offset = 0)
        {
            return CheckSpawn(rng.PeekRand(SpawnPosition + offset));
        }

        public bool CheckSpawn(uint prng) //TODO: Consider making these methods private.
        {
            return RandToPercent(prng) < SpawnChance;
        }

        public bool CheckGil(uint prng)
        {
            return RandToPercent(prng) < GilChance;
        }

        public bool CheckItem(uint prng)
        {
            return RandToPercent(prng) < ItemChance;
        }

        /// <summary>
        /// Checks result of opening chest
        /// </summary>
        /// <param name="rng"></param>
        /// <param name="offset"></param>
        public ChestResult CheckChest(IRNG rng, int offset = 0)
        {
            return CheckChest(rng.PeekRand(offset), rng.PeekRand(offset + 1));
        }

        public ChestResult CheckChest(uint prng1, uint prng2)
        {
            if (CheckGil(prng1))
            {
                return new ChestResult(RandToGil(prng2));
            }
            else if (CheckItem(prng2))
            {
                return new ChestResult(ChestResultType.Item1);
            }
            else
            {
                return new ChestResult(ChestResultType.Item2);
            }
        }

        private int RandToGil(uint prng)
        {
            if (MaxGilAmount == 0)
            {
                return 1;
            }
            else return 1 + (int)(prng % MaxGilAmount);
        }

        private int RandToPercent(uint prng)
        {
            return (int)(prng % 100);
        }

        public override bool Equals(Object obj)
        {
            return obj is Chest && this == (Chest)obj;
        }
        public override int GetHashCode()
        {
            return SpawnChance.GetHashCode() ^ SpawnPosition.GetHashCode() ^ GilChance.GetHashCode() ^ ItemChance.GetHashCode() ^ MaxGilAmount.GetHashCode();
        }
        public static bool operator ==(Chest x, Chest y)
        {
            return  x.SpawnChance   == y.SpawnChance &&
                    x.SpawnPosition == y.SpawnPosition &&
                    x.GilChance     == y.GilChance &&
                    x.ItemChance    == y.ItemChance &&
                    x.MaxGilAmount  == y.MaxGilAmount;
        }
        public static bool operator !=(Chest x, Chest y)
        {
            return !(x == y);
        }
    }
}
