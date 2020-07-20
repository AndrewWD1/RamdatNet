using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Performs right-to-left function composition. The last argument may have any arity; the remaining arguments must be unary.
        /// </summary>
        /// <code>
        /// Func{int, int} composed
        ///   = R.Compose(new Func{int, int}[] {
        ///       x => x + 1,
        ///       x => x % 7
        ///     })
        /// composed(8) //-> 2
        /// composed(6) //-> 7
        /// </code>
        public static Func<T, T> Compose<T>(IEnumerable<Func<T, T>> Fns)
            => x => Fns.Reverse().Aggregate(x, (a, c) => c(a));

        public static Func<T, Z> Compose<T, K, Z>(Func<K, Z> f, Func<T, K> g)
            => x => f(g(x));
    }
}