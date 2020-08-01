using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        public static Func<T, T> Pipe<T>(IEnumerable<Func<T, T>> Fns)
            => x => Fns.Aggregate(x, (a, c) => c(a));
    }
}