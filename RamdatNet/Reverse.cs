using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list or string with the elements or characters in reverse order.
        /// </summary>
        /// <code>
        /// R.Reverse( new int[] { 1, 2, 3 });  //=> { 3, 2, 1 }
        /// </code>
        public static IEnumerable<T> Reverse<T>(IEnumerable<T> list)
            => list.Reverse();

        /// <summary>
        /// Returns a new list or string with the elements or characters in reverse order.
        /// </summary>
        /// <code>
        /// R.Reverse("abc");  //=> "cba"
        /// </code>
        public static string Reverse(string str)
        {
            return String.Join("", Reverse(str));
        }
    }
}