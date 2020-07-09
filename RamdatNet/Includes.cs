using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns true if the specified value is equal, in R.equals terms, to at least one element of the given list; false otherwise. Works also with strings. 
        /// </summary>
        /// <code>
        /// R.Includes(3, new int[] { 1, 2, 3 }); //=> true
        /// R.Includes(4, new int[] { 1, 2, 3 }); //=> false
        /// R.Includes(new int[] { 42 }, new int[][] { { 42 } }); //=> true
        /// </code>
        public static bool Includes<T>(T t, IList<T> list)
            => list.Contains(t);

        /// <summary>
        /// Returns true if the specified value is equal, in R.equals terms, to at least one element of the given list; false otherwise. Works also with strings.
        /// </summary>
        /// <code>
        /// R.Head(new string[] { "fi", "fo", "fum" } ); //=> "fi"
        /// R.Head(new int[] {}); //=> undefined
        /// R.Head("abc"); //=> "a"
        /// R.Head(""); //=> ""
        /// </code>
        public static bool Includes(string t, string list)
            => list.Contains(t);
    }
}