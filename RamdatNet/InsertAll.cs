using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Inserts the supplied element into the list, at the specified index. Note that this is not destructive: it returns a copy of the list with the changes.
        /// </summary>
        /// <code>
        /// R.InsertAll(2, new int[] { 7, 8, 9 }, new int[] { 1, 2, 3, 4 }); //=> { 1, 2, 7, 8, 9, 3, 4 }
        /// </code>
        public static IList<T> InsertAll<T>(int ind, IList<T> ts, IList<T> list)
        {
            if (ind > list.Count)
                throw new ArgumentOutOfRangeException();

            T[] arr = new T[list.Count + ts.Count];

            for (int i = 0; i < ind; i++)
                arr[i] = list[i];

            for (int i = ind; i < ind + ts.Count; i++)
                arr[i] = ts[i - ind];

            for (int i = ind; i < list.Count; i++)
                arr[i + ts.Count] = list[i];

            return arr;
        }
    }
}