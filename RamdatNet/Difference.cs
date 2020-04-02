using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Finds the set of all elements in the first list not contained in the second list.
        /// </summary>
        /// <code>
        /// var set1 = new HashSet{int} { 1, 2, 3, 4 };
        /// var set2 = new HashSet{int} { 7, 6, 5, 4, 3 };
        /// R.Difference(set1, set2); //=> { 1, 2 }
        /// </code>
        public static HashSet<T> Difference<T>(HashSet<T> a, HashSet<T> b)
            => new HashSet<T>(a.Where(t => !b.Contains(t)));
    }
}