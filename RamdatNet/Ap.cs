using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Ap applies a list of functions to a list of values.
        /// </summary>
        /// <code>
        /// R.Ap(
        ///   new Func{int, int}[] { R.Multiply(2), R.Add(3) },
        ///   new int[] { 1, 2, 3 }
        /// );  //=> { 2, 4, 6, 4, 5, 6 }
        /// R.Ap(
        ///   new Func{string, string}[] { R.Concat("tasty "), R.ToUpper },
        ///   new string[] { "pizza", "salad" }
        /// );  //=> { "tasty pizza", "tasty salad", "PIZZA", "SALAD" }
        /// </code>
        public static IEnumerable<K> Ap<T, K>(IEnumerable<Func<T, K>> fns, IEnumerable<T> list)
            => fns.Select(fn => list.Select(fn)).Aggregate((a, c) => a.Concat(c));
    }
}