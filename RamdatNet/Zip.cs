using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Creates a new list out of the two supplied by pairing up equally-positioned items from both lists. The returned list is truncated to the length of the shorter of the two input lists.
        /// </summary>
        /// <code>
        /// R.Zip(new int[] { 1, 2, 3 }, new char[] { 'a', 'b', 'c' }); //=> { (1, 'a'), (2, 'b'), (3, 'c') }
        /// </code>
        public static IList<(T, K)> Zip<T, K>(IList<T> listT, IList<K> listK)
        {
            var list = new List<(T, K)>();

            int i = 0;
            while (i < listT.Count() && i < listK.Count())
            {
                list.Add((listT[i], listK[i]));
                i += 1;
            }

            return list;
        }
    }
}