using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a copy of the list, sorted according to the comparer function, which should accept two values at a time and return a negative number if the first value is smaller, a positive number if it's larger, and zero if they are equal.
        /// </summary>
        /// <code>
        /// static int diff(int a, int b) => a - b;
        /// R.Sort(diff, new int[] { 4, 2, 7, 5 }); //=> { 2, 4, 5, 7 }
        /// </code>

        public static IEnumerable<T> Sort<T>(Comparison<T> fn, IEnumerable<T> list)
        {
            var newList = new List<T>(list);
            newList.Sort(fn);

            return newList;
        }
    }
}