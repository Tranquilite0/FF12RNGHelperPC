using System.Text;
using System;

namespace FF12RNGHelperPC
{
    /// <summary>
    /// Represents the result of the steal command.
    /// </summary>
    public struct StealResult : IResult
    {
        // Strings for display in the UI
        private const string Rare = "Rare";
        private const string Uncommon = "Uncommon";
        private const string Common = "Common";
        private const string None = "None";
        private const string Linker = " + ";

        public readonly bool RareItem;
        public readonly bool UncommonItem;
        public readonly bool CommonItem;

        public StealResult(bool rare, bool uncommon, bool common)
        {
            RareItem = rare;
            UncommonItem = uncommon;
            CommonItem = common;
        }

        public StealResult(StealResult inResult)
        {
            RareItem = inResult.RareItem;
            UncommonItem = inResult.UncommonItem;
            CommonItem = inResult.CommonItem;
        }

        /// <summary>
        /// Returns whether you got anything.
        /// </summary>
        /// <returns>true if you got at least one thing, false otherwise (FeelsBadMan).</returns>
        public bool Any()
        {
            return RareItem || UncommonItem || CommonItem;
        }

        /// <summary>
        /// Print a pretty string containing the contents of your haul.
        /// </summary>
        public override string ToString()
        {
            int NumItems = 0;
            StringBuilder ToReturn = new StringBuilder();
            if(RareItem)
            {
                NumItems++;
                ToReturn.Append(Rare);
            }

            if(UncommonItem)
            {
                NumItems++;
                if(NumItems > 1)
                {
                    ToReturn.Append(Linker);
                }
                ToReturn.Append(Uncommon);
            }

            if(CommonItem)
            {
                NumItems++;
                if(NumItems > 1)
                {
                    ToReturn.Append(Linker);
                }
                ToReturn.Append(Common);
            }

            if(NumItems == 0)
            {
                ToReturn.Append(None);
            }

            return ToReturn.ToString();
        }

        /// <summary>
        /// Returns true if this steal result is same or better than the provided one.
        /// </summary>
        /// <param name="other">Steal Result to compare against.</param>
        /// <returns>Bool representing the comparison is same or better.</returns>
        public bool SameOrBetter(StealResult other)
        {
            if (other.RareItem && !this.RareItem)
            {
                return false;
            }
            if (other.UncommonItem && !this.UncommonItem)
            {
                return false;
            }
            if (other.CommonItem && !this.CommonItem)
            {
                return false;
            }
            return true;
        }

        public bool SameOrBetter(IResult other)
        {
            if (other is StealResult)
            {
                return SameOrBetter((StealResult)other);
            }
            else return false;
        }

        public bool Same(StealResult other)
        {
            return this.Equals(other);
        }

        public bool Same(IResult other)
        {
            return this.Equals(other);
        }

        public override bool Equals(Object obj)
        {
            return obj is StealResult && this == (StealResult)obj;
        }
        public override int GetHashCode()
        {
            return RareItem.GetHashCode() ^ Uncommon.GetHashCode() ^ CommonItem.GetHashCode();
        }
        public static bool operator ==(StealResult x, StealResult y)
        {
            return x.RareItem == y.RareItem && x.UncommonItem == y.UncommonItem && x.CommonItem == y.CommonItem;
        }
        public static bool operator !=(StealResult x, StealResult y)
        {
            return !(x == y);
        }
    }
}
