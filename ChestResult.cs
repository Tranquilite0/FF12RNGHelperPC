using System;

namespace FF12RNGHelperPC
{
    public enum ChestResultType : int
    {
        Gil = 0,
        Item1 = -1,
        Item2 = -2,
    }

    /// <summary>
    /// Represents the result of opening a chest.
    /// </summary>
    public struct ChestResult : IResult
    {
        private const string GIL_FORMAT = "{0} gil";
        private const string ITEM_1_STR = "Item1";
        private const string ITEM_2_STR = "Item2";
        private const string UNKNOWN = "Unknown";

        /// <summary>
        /// -1 for item1, -2 for item2, 0 and above for gil.
        /// </summary>
        private readonly int _result;

        public int RawResult
        {
            get
            {
                return _result;
            }
        }

        public string Result
        {
            get
            {
                return this.ToString();
            }
        }

        public ChestResultType ResultType
        {
            get
            {
                if (RawResult < 0)
                {
                    return (ChestResultType)_result;
                }
                else return ChestResultType.Gil;

            }
        }

        public int GilAmount
        {
            get
            {
                if (_result > 0)
                {
                    return _result;
                }
                else return 0;
            }
        }

        public bool HasGil
        {
            get
            {
                return _result >= 0;
            }
        }

        public bool HasItem1
        {
            get
            {
                return _result == -1;
            }
        }

        public bool HasItem2
        {
            get
            {
                return _result == -2;
            }
        }

        public ChestResult(int rawResult)
        {
            _result = rawResult;
        }

        public ChestResult(ChestResultType result)
        {
            _result = (int)result;
        }

        public ChestResult(ChestResultType resultType, int gilAmount)
        {
            if (resultType == ChestResultType.Gil)
            {
                _result = gilAmount;
            }
            else
            {
                _result = (int)resultType;
            }
        }

        public bool Same(ChestResult other)
        {
            return this.Equals(other);
        }

        public bool Same(IResult other)
        {
            return this.Equals(other);
        }

        /// <summary>
        /// Returns true if Result contents are same or if this has more gil than other. False otherwise.
        /// </summary>
        public bool SameOrBetter(ChestResult other)
        {
            if (this.HasItem1 && other.HasItem1)
            {
                return true;
            }
            else if (this.HasItem2 && other.HasItem2)
            {
                return true;
            }
            else if (this.HasGil && other.HasGil)
            {
                return this.GilAmount >= other.GilAmount;
            }
            else return false;
        }

        public bool SameOrBetter(IResult other)
        {
            if(other is ChestResult)
            {
                return SameOrBetter((ChestResult)other);
            }
            else return false;
        }

        public override string ToString()
        {
            if(_result >= 0)
            {
                return String.Format(GIL_FORMAT, _result);
            }
            else if(_result == -1)
            {
                return ITEM_1_STR;
            }
            else if(_result == -2)
            {
                return ITEM_2_STR;
            }
            else
            {
                return UNKNOWN;
            }
        }

        public override bool Equals(Object obj)
        {
            return obj is ChestResult && this == (ChestResult)obj;
        }
        public override int GetHashCode()
        {
            return _result.GetHashCode();
        }
        public static bool operator ==(ChestResult x, ChestResult y)
        {
            return x._result == y._result;
        }
        public static bool operator !=(ChestResult x, ChestResult y)
        {
            return !(x == y);
        }
    }
}
