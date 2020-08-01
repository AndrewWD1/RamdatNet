using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns all but the last element of the given list or string.
        /// </summary>
        /// <code>
        /// R.Init(new int[] { 1, 2, 3 });  //=> { 1, 2 }
        /// R.Init(new int[] { 1, 2 });     //=> { 1 }
        /// R.Init(new int[] { 1 });        //=> { }
        /// R.Init(new int[] { });         //=> { }
        /// </code>
        public static IList<T> Init<T>(IList<T> list)
        {
            if (list.Count == 0) return new T[0];
            T[] arr = new T[list.Count - 1];

            for (int i = 0; i < list.Count - 1; i++)
                arr[i] = list[i];

            return arr;
        }

        /// <summary>
        /// Returns all but the last element of the given list or string.
        /// </summary>
        /// <code>
        /// R.Init('abc');  //=> 'ab'
        /// R.Init('ab');   //=> 'a'
        /// R.Init('a');    //=> ''
        /// R.Init('');     //=> ''
        /// </code>
        public static string Init(string str)
        {
            return String.Join("", Init<char>(str.ToCharArray()));
        }
    }
}