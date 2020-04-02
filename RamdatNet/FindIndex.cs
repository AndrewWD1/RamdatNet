using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns the index of the first element of the list which matches the predicate, or -1 if no element matches.
        /// </summary>
        /// <code>
        /// HasB[] list = { new HasB(1), new HasB(3) };
        /// var result = R.FindIndex((HasB x) => x.B == 3)(list);
        /// // => 1
        /// </code>
        public static Func<IList<T>, int> FindIndex<T>(Func<T, bool> fn)
            => list =>
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (fn(list[i]))
                        return i;
                }
                return -1;
            };

        /// <summary>
        /// Returns the index of the first element of the list which matches the predicate, or -1 if no element matches.
        /// </summary>
        /// <code>
        /// HasB[] list = { new HasB(1), new HasB(3) };
        /// var result = R.FindIndex((HasB x) => x.B == 3)(list);
        /// // => 1
        /// </code>
        public static int FindIndex<T>(Func<T, bool> fn, IList<T> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                if (fn(list[i]))
                    return i;
            }
            return -1;
        }
    }
}