using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried Reduce.
        /// </summary>
        public static Func<K, Func<IEnumerable<T>, K>> Reduce<T, K>(Func<T, K, K> fn)
            => seed => list => list.Aggregate<T, K>(seed, (x, y) => fn(y, x));

        /// <summary>
        /// Standard Reduce.
        /// </summary>
        public static K Reduce<T, K>(Func<T, K, K> fn, K seed, IEnumerable<T> list)
            => list.Aggregate<T, K>(seed, (x, y) => fn(y, x));
    }
}