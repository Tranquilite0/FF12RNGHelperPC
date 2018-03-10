using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF12RNGHelperPC
{
    public interface IResult
    {
        bool Same(IResult other);
        bool SameOrBetter(IResult other);
    }
}
