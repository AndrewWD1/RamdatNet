using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Creates a new function that, when invoked, caches the result of calling fn for a given argument set and returns the result. Subsequent calls to the memoized fn with the same argument set will not result in an additional call to fn; instead, the cached result for that set of arguments will be returned.
        /// </summary>
        /// <code>
        /// int count = 0;
        /// Func{int, int} factorial = R.Memoize(n => {
        ///   count += 1;
        ///   return R.Reduce((a, c) => a * c, 1, (R.Range(1, n + 1)));
        /// });
        /// factorial(5); //=> 120
        /// factorial(5); //=> 120
        /// factorial(5); //=> 120
        /// count; //=> 1
        /// </code>
        public static Func<T, K> Memoize<T, K>(Func<T, K> fn)
        {
            Dictionary<T, K> memo = new Dictionary<T, K>();

            return (T t) =>
            {
                if (memo.ContainsKey(t)) return memo[t];

                K newVal = fn(t);
                memo[t] = newVal;
                return newVal;
            };
        }
    }
}