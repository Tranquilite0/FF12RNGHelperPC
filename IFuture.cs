using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FF12RNGHelperPC
{
    /// <summary>
    /// Interface for finding when a DesiredResult will happen.
    /// </summary>
    public interface IFuture
    {
        IResult DesiredResult { get; set; }
        int SearchDepth { get; set; }
        int GetFuture(IRNG rng, int offset = 0);
        int SyncFuture(int syncAmount, IRNG rng, int offset = 0);
    }
}
