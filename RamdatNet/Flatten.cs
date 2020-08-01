using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> list)
            => list.Aggregate(new List<T>(), (a, c) => a.Concat(c).ToList());
    }
}