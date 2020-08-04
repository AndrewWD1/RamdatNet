using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list containing only one copy of each element in the original list.
        /// </summary>
        /// <code>
        /// R.Uniq(new int[] { 1, 1, 2, 1 }); //=> { 1, 2 }
        /// </code>
        public static IList<T> Uniq<T>(IList<T> list)
            => new HashSet<T>(list).ToList();
    }
}