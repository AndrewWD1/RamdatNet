using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Creates a new list out of the two supplied by creating each possible pair from the lists.
        /// </summary>
        /// <code>
        /// R.XProd(new int[] { 1, 2 }, new char[] { 'a', 'b' }); //=> { (1, 'a'), (1, 'b'), (2, 'a'), (2, 'b') }
        /// </code>
        public static IList<(T, K)> XProd<T, K>(IList<T> listT, IList<K> listK)
        {
            var list = new List<(T, K)>();

            foreach (T t in listT)
            {
                foreach (K k in listK)
                {
                    list.Add((t, k));
                }
            }

            return list;
        }
    }
}