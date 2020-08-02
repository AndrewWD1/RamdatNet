using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Creates a new list out of the two supplied by applying the function to each equally-positioned pair in the lists. The returned list is truncated to the length of the shorter of the two input lists.
        /// </summary>
        /// <code>
        /// Func{int, char, string} f = (x, y) =>  $"{x} _ {y}";
        /// R.ZipWith(f)(new int[] { 1, 2, 3 }, new char[] { 'a', 'b', 'c' }); //=> { "1 _ a", "2 _ b", "3 _ c" }
        /// </code>
        public static Func<IList<T>, IList<K>, IList<U>> ZipWith<T, K, U>(Func<T, K, U> fn)
            => (listT, listK)
                => Zip(listT, listK).Select(z => fn(z.Item1, z.Item2)).ToList();
    }
}