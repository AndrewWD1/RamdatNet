using System;
using System.Linq;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the elements of the given list or string (or object with a slice method) from fromIndex (inclusive) to toIndex (exclusive).
        /// </summary>
        /// <code>
        /// R.Slice(1, 3, new char[] { 'a', 'b', 'c', 'd' }); //=> { 'b', 'c' }
        /// R.Slice(0, -1, new char[] { 'a', 'b', 'c', 'd' }); //=> { 'a', 'b', 'c' }
        /// </code>
        public static IList<T> Slice<T>(int a, int b, IList<T> list)
        {
            var newList = new List<T>();

            var _a = Mod(a, list.Count());
            var _b = Mod(b, list.Count());

            for (int i = _a; i < _b; i++)
                newList.Add(list[i]);

            return newList;
        }

        /// <summary>
        /// Returns the elements of the given list or string (or object with a slice method) from fromIndex (inclusive) to toIndex (exclusive).
        /// </summary>
        /// <code>
        /// R.Slice(0, 3, "ramda"); //=> "ram"
        /// </code>
        public static string Slice(int a, int b, string str)
            => String.Join("", Slice(a, b, str.ToCharArray()));
    }
}