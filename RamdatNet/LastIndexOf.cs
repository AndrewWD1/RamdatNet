using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the position of the last occurrence of an item in an array, or -1 if the item is not included in the array.
        /// </summary>
        /// <code>
        /// R.LastIndexOf(3)(new int[] { -1, 3, 3, 0, 1, 2, 3, 4 }); //=> 6
        /// R.LastIndexOf(10)(new int[] { 1, 2, 3, 4 }); //=> -1
        /// </code> 
        public static Func<IList<T>, int> LastIndexOf<T>(T t)
        where T : IComparable
            => list =>
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].CompareTo(t) == 0)
                        return i;
                }

                return -1;
            };
    }
}