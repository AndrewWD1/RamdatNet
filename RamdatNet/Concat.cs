using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the result of concatenating the given lists or strings.
        /// </summary>
        /// <code>
        /// R.Concat(new string[] {"ABC", "DEF"}); // "ABCDEF"
        /// </code>
        public static string Concat(IEnumerable<string> list)
            => list.Aggregate("", (a, c) => a += c);

        /// <summary>
        /// When given a single string (as opposed to a list) it acts as a curried function that concatatenates the first argument with the second.
        /// </summary>
        /// <code>
        /// R.Concat("ABC")("DEF"); // "ABCDEF"
        /// </code>
        public static Func<string, string> Concat(string str1)
            => str2 => R.Concat(new string[] { str1, str2 });

        /// <summary>
        /// Returns the result of concatenating the given lists or strings.
        /// </summary>
        /// <code>
        /// R.concat(new int[] { { 4, 5, 6 }, { 1, 2, 3 } });
        /// //=> { 4, 5, 6, 1, 2, 3 }
        /// </code>
        public static IEnumerable<T> Concat<T>(IEnumerable<IEnumerable<T>> list)
            => list.Aggregate(new List<T>(), (a, c) => a.Concat(c).ToList());
    }
}