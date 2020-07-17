using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns true if no elements of the list match the predicate, false otherwise.
        /// </summary>
        /// <code>
        /// Predicate{int} isEven = n => n % 2 === 0;
        /// Predicate{int{ isOdd = n => n % 2 === 1;
        /// R.None(isEven, new int[] { 1, 3, 5, 7, 9, 11 }); //=> true
        /// R.None(isOdd, new int[] { 1, 3, 5, 7, 8, 11 }); //=> false
        /// </code>
        public static Predicate<IList<T>> None<T>(Predicate<T> fn)
            => list =>
            {
                foreach (T t in list)
                    if (fn(t)) return false;

                return true;
            };
    }
}