using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns true if at least one of the elements of the list match the predicate, false otherwise.
        /// </summary>
        /// <code>
        /// int[] list = { 2, 3, 5 };
        /// R.Any((int x) => x % 2 == 0)(list); //-> true
        /// R.Any((int x) => x > 6)(list); //-> false
        /// </code>
        public static Predicate<IEnumerable<T>> Any<T>(Predicate<T> p)
            => list => list.Aggregate(false, (a, c) => a || p(c));

        /// <summary>
        /// Returns true if at least one of the elements of the list match the predicate, false otherwise.
        /// </summary>
        /// <code>
        /// int[] list = { 2, 3, 5 };
        /// R.Any(x => x % 2 == 0, list); //-> true
        /// R.Any(x => x > 6, list); //-> false
        /// </code>
        public static bool Any<T>(Predicate<T> p, IEnumerable<T> list)
            => list.Aggregate(false, (a, c) => a || p(c));
    }
}