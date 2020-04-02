using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Finds the set of all elements in the first list not contained in the second list. Duplication is determined according to the value returned by applying the supplied predicate to two list elements.
        /// </summary>
        /// <code>
        /// var set1 = new HashSet{int} { 1, 2, 3, 4 };
        /// var set2 = new HashSet{int} { 7, 6, -2, 4, 3 };
        /// Func{int, int, bool} cmp = (x, y)
        ///   => Math.Abs(x) == Math.Abs(y);
        /// R.DifferenceWith(cmp)(set1, set2); //=> { 1 }
        /// </code>
        public static Func<HashSet<T>, HashSet<T>, HashSet<T>> DifferenceWith<T>(Func<T, T, bool> Comparer)
            => (a, b) =>
            {
                HashSet<T> z = new HashSet<T>();
                foreach (T item1 in a)
                {
                    Boolean found = false;
                    foreach (T item2 in b)
                    {
                        if (Comparer(item1, item2)) found = true;
                    }
                    if (!found) z.Add(item1);
                }
                return z;
            };
    }
}