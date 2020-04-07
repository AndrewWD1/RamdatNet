using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns the index of the last element of the list which matches the predicate, or -1 if no element matches.
        /// </summary>
        /// <code>
        /// HasAB[] xs = { new HasAB(1, 0), new HasAB(1, 1) };
        /// R.FindLastIndex((HasAB x) => x.A == 1)(xs); //=> 1
        /// R.FindLastIndex((HasAB x) => x.A == 4)(xs); //=> -1
        /// </code>
        public static Func<IList<T>, int> FindLastIndex<T>(Func<T, bool> fn)
            => list =>
            {
                for (int i = list.Count() - 1; 0 <= i; i--)
                {
                    if (fn(list[i]))
                        return i;
                }
                return -1;
            };
    }
}