using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        public static IList<int> Range(int start, int end)
        {
            return Enumerable.Range(start, end - start)
                             .ToList();
        }
    }
}