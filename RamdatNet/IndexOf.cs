using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the position of the first occurrence of an item in an array, or -1 if the item is not included in the array. 
        /// </summary>
        /// <code>
        /// R.IndexOf(3, new int[] { 1,2,3,4 }); //=> 2
        /// R.IndexOf(10, new int[] { 1,2,3,4 }); //=> -1
        /// </code>
        public static int IndexOf<T>(T t, IList<T> list)
        where T : IComparable
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(t) == 0)
                    return i;
            }

            return -1;
        }
    }
}