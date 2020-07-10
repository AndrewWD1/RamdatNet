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
        /// R.Insert(2, 9, new int[] { 1, 2, 3, 4 }); //=> { 1, 2, 9, 3, 4 }
        /// </code>
        public static IList<T> Insert<T>(int ind, T t, IList<T> list)
        {
            if (ind > list.Count)
                throw new ArgumentOutOfRangeException();

            T[] arr = new T[list.Count + 1];

            arr[ind] = t;

            for (int i = 0; i < ind; i++)
                arr[i] = list[i];

            for (int i = ind; i < list.Count; i++)
                arr[i + 1] = list[i];

            Console.WriteLine(String.Join(", ", arr));

            return arr;
        }
    }
}