using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Applies a function to the value at the given index of an array, returning a new copy of the array with the element at the given index replaced with the result of the function application.
        /// </summary>
        /// <code>
        /// int[] list = { 1, 2, 3 };
        /// R.Adjust( 1, R.Add(1), list ); //-> { 1, 3, 3 }
        /// </code>
        public static List<T> Adjust<T>(int index, Func<T, T> fn, IList<T> list)
        {
            List<T> newList = new List<T>(list);
            if (index >= list.Count) return newList;
            newList[index] = fn(newList[index]);
            return newList;
        }
    }
}