using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the first element of the given list or string. In some libraries this function is named first.
        /// </summary>
        /// <code>
        /// R.Head(new string[] { "fi", "fo", "fum" } ); //=> "fi"
        /// R.Head(new int[] {}); //=> undefined
        /// R.Head("abc"); //=> "a"
        /// R.Head(""); //=> ""
        /// </code>
        public static T Head<T>(IList<T> list)
        {
            if (list.Count == 0)
                throw new ArgumentException();

            return list[0];
        }

        /// <summary>
        /// Returns the first element of the given list or string. In some libraries this function is named first.
        /// </summary>
        /// <code>
        /// R.Head(new string[] { "fi", "fo", "fum" } ); //=> "fi"
        /// R.Head(new int[] {}); //=> undefined
        /// R.Head("abc"); //=> "a"
        /// R.Head(""); //=> ""
        /// </code>
        public static string Head(string str)
        {
            if (str == "") return "";

            return str[0].ToString();
        }
    }
}