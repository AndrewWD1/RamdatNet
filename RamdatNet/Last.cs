using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the last element of the given list or string.
        /// </summary>
        /// <code>
        /// R.Last(new string[] { "fi", "fo", "fum" }); //=> "fum"
        /// R.Last(new int[] { }); //=> ArgumentException
        /// </code> 
        public static T Last<T>(IList<T> list)
        {
            if (list.Count() == 0)
                throw new ArgumentException();

            return list[list.Count() - 1];
        }

        /// <summary>
        /// Returns the last element of the given list or string.
        /// </summary>
        /// <code>
        /// R.last("abc"); //=> "c"
        /// R.last(""); //=> ""
        /// </code> 
        public static string Last(string str)
        {
            if (str.Length == 0)
                return "";

            return str[str.Length - 1].ToString();
        }
    }
}