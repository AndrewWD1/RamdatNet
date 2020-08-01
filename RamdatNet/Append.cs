using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns a new list containing the contents of the given list, followed by the given element.
        /// </summary>
        /// <code>
        /// R.Append("tests")( new string[] { "write", "more" });
        /// //=> { "write", "more", "tests" }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> Append<T>(T t)
            => list => Append(t, list);

        /// <summary>
        /// Returns a new list containing the contents of the given list, followed by the given element.
        /// </summary>
        /// <code>
        /// R.Append("tests", new string[] { "write", "more" });
        /// //=> { "write", "more", "tests" }
        /// </code>
        public static IEnumerable<T> Append<T>(T t, IEnumerable<T> list)
        {
            List<T> newList = new List<T>(list)
            {
                t
            };
            return newList;
        }
    }
}