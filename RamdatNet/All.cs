using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns true if all elements of the list match the predicate, false if there are any that don't.
        /// </summary>
        /// <code>
        /// int[] list = { 2, 4, 6 };
        /// R.All(x => x % 2 == 0)(list); //-> true
        /// R.All(x => x > 3)(list); //-> false
        /// </code>
        public static Func<IEnumerable<T>, bool> All<T>(Predicate<T> p)
            => list => list.Aggregate(true, (a, c) => a && p(c));

        /// <summary>
        /// Returns true if all elements of the list match the predicate, false if there are any that don't.
        /// </summary>
        /// <code>
        /// int[] list = { 2, 4, 6 };
        /// R.All((int x) => x % 2 == 0, list) //-> true
        /// R.All((int x)=> x > 3, list) //-> false
        /// </code>
        public static bool All<T>(Predicate<T> p, IEnumerable<T> list)
            => list.Aggregate(true, (a, c) => a && p(c));
    }
}