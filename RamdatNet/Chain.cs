using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Chain maps a function over a list and concatenates the results. chain is also known as flatMap in some libraries.
        /// </summary>
        /// <code>
        /// Func{int, IEnumerable{int}} duplicate
        ///   = n => new int[] { n, n };
        /// R.Chain(duplicate, new int[] { 1, 2, 3 });
        /// //-> { 1, 1, 2, 2, 3, 3 }
        /// </code>
        public static IEnumerable<K> Chain<T, K>(Func<T, IEnumerable<K>> fn, IEnumerable<T> list)
        {
            IList<IEnumerable<K>> a = new List<IEnumerable<K>>();
            foreach (var i in list) a.Add(fn(i));
            return Flatten(a);
        }
    }
}