using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns all but the first element of the given list or string (or object with a tail method).
        /// </summary>
        /// <code>
        /// R.Tail(new int[] { 1, 2, 3 });  //=> { 2, 3 }
        /// R.Tail(new int[] { 1, 2 });     //=> { 2 }
        /// R.Tail(new int[] { 1 });        //=> {  }
        /// R.Tail(new int[] {  });         //=> {  }
        /// </code>
        public static IEnumerable<T> Tail<T>(IEnumerable<T> list)
            => list.Skip(1);

        /// <summary>
        /// Returns all but the first element of the given list or string (or object with a tail method).
        /// </summary>
        /// <code>
        /// R.Tail(new int[] { 1, 2, 3 });  //=> { 2, 3 }
        /// R.Tail(new int[] { 1, 2 });     //=> { 2 }
        /// R.Tail(new int[] { 1 });        //=> {  }
        /// R.Tail(new int[] {  });         //=> {  }
        /// </code>
        public static IList<T> Tail<T>(IList<T> list)
            => list.Skip(1).ToList();

        /// <summary>
        /// Returns all but the first element of the given list or string (or object with a tail method).
        /// </summary>
        /// <code>
        /// R.Tail("dabc");  //=> "bc"
        /// R.Tail("ab");   //=> "b"
        /// R.Tail("a");    //=> ""
        /// R.Tail("");     //=> ""
        /// </code>
        public static string Tail(string str)
            => String.Join("", str.Skip(1));
    }
}