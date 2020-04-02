using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Standard Reduce.
        /// </summary>
        public static K Reduce<T, K>(Func<T, K, K> fn, K seed, IEnumerable<T> list)
            => list.Aggregate<T, K>(seed, (x, y) => fn(y, x));
    }
}