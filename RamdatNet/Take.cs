using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the first n elements of the given list, string, or transducer/transformer (or object with a take method).
        /// </summary>
        /// <code>
        /// R.Take{int}(3)(new int[] { 1, 2, 3, 4, 5 }) //=> { 1, 2, 3 }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> Take<T>(int n)
            => list => list.Take(n);
    }
}