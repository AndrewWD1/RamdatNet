using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried Map. Takes a function that acts on the elements of an IEnumrable and return a function that applies the function to each element of the IEnumerable and returns an IEnumarable.
        /// </summary>
        /// <code>
        /// R.Map((int x)=> x * 2)(new int[] { 1, 2, 3 });
        /// //=> { 2, 4, 6}
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<K>> Map<T, K>(Func<T, K> fn)
        => list => list.Select(fn);

        /// <summary>
        /// Standard Map. Takes a function and an enumerable. Applies the function to each element of the enumerable, and returns the new Enumerable
        /// </summary>
        /// <code>
        /// R.Map((int x)=> x * 2, new int[] { 1, 2, 3 });
        /// //=> { 2, 4, 6}
        /// </code>
        public static IEnumerable<K> Map<T, K>(Func<T, K> fn, IEnumerable<T> list)
            => list.Select(fn);
    }
}