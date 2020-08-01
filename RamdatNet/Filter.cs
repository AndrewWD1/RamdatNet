using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried Filter. Takes a predicate and a Enumerable, and returns a new Enumerable of the same type containing the members of the given filterable which satisfy the given predicate.
        /// </summary>
        /// <code>
        /// R.Filter((int x) => x % 2 == 0)(new int[] { 1, 2, 3, 4 });
        /// //=> { 2, 4 }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> Filter<T>(Func<T, bool> fn)
            => list => list.Where(fn);

        /// <summary>
        /// Standard Filter.
        /// </summary>
        /// <code>
        /// R.Filter((int x) => x % 2 == 0, new int[] { 1, 2, 3, 4 });
        /// //=> { 2, 4 }
        /// </code>
        public static IEnumerable<T> Filter<T>(Func<T, bool> fn, IEnumerable<T> list)
            => list.Where(fn);
    }
}