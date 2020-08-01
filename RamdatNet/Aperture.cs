using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns a new list, composed of n-tuples of consecutive elements. If n is greater than the length of the list, an empty list is returned.
        /// </summary>
        /// <code>
        /// R.Aperture(2)(new int[] { 1, 2, 3, 4, 5 });
        /// //=> { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } }
        /// R.Aperture(3)(new int[] { 1, 2, 3, 4, 5 });
        /// //=> { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } }
        /// R.Aperture(7)(new int[] { 1, 2, 3, 4, 5 });
        /// //=> {}
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<IEnumerable<T>>> Aperture<T>(int num)
            => list => Aperture(num, list);

        /// <summary>
        /// Returns a new list, composed of n-tuples of consecutive elements. If n is greater than the length of the list, an empty list is returned.
        /// </summary>
        /// <code>
        /// R.Aperture(2, new int[] { 1, 2, 3, 4, 5 });
        /// //=> { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } }
        /// R.Aperture(3, new int[] { 1, 2, 3, 4, 5 });
        /// //=> { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } }
        /// R.Aperture(7, new int[] { 1, 2, 3, 4, 5 });
        /// //=> {}
        /// </code>
        public static IEnumerable<IEnumerable<T>> Aperture<T>(int num, IEnumerable<T> list)
        {
            List<IEnumerable<T>> a = new List<IEnumerable<T>>();
            if (num > list.Count()) return a;

            int i = 0;
            while (i <= list.Count() - num)
            {
                a.Add(list.Skip(i).Take(num));
                i += 1;
            }
            return a;
        }
    }
}