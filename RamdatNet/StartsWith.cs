using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Checks if a list starts with the provided sublist.
        /// Similarly, checks if a string starts with the provided substring.
        /// </summary>
        /// <code>
        /// R.StartsWith(new char[] { 'a' })(new char[] { 'a', 'b', 'c' }); //=> true
        /// R.StartsWith(new char[] { 'b' })(new char[] { 'a', 'b', 'c' }); //=> false
        /// </code>
        public static Func<IList<T>, bool> StartsWith<T>(IList<T> subList)
            where T : IComparable
            => list =>
            {
                if (subList.Count > list.Count)
                    return false;

                for (int i = 0; i < subList.Count; i++)
                {
                    if (list[i].CompareTo(subList[i]) != 0) return false;
                }

                return true;
            };

        /// <summary>
        /// Checks if a list starts with the provided sublist.
        /// Similarly, checks if a string starts with the provided substring.
        /// </summary>
        /// <code>
        /// R.StartsWith("a")("abc"); //=> true
        /// R.StartsWith("b")("abc");  //=> false
        /// </code>
        public static Func<string, bool> StartsWith(string subString)
            => str => str.StartsWith(subString);
    }
}