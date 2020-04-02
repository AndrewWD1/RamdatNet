using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> list)
            => list.Aggregate(new List<T>(), (a, c) => a.Concat(c).ToList());
    }
}