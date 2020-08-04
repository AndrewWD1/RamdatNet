using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list containing just the unique elements of the argument lists.
        /// </summary>
        /// <code>
        /// R.Union(
        ///     new int[] { 1, 2, 3 }, 
        ///     new int[] { 2, 3, 4 }
        /// ); //=> { 1, 2, 3, 4 }
        /// </code>
        public static IList<T> Union<T>(IList<T> list1, IList<T> list2)
        {
            var set1 = new HashSet<T>(list1);
            var set2 = new HashSet<T>(list2);

            set1.UnionWith(set2);

            return set1.ToList();
        }

        /// <summary>
        /// Returns a new set containing just the unique elements of the argument sets.
        /// </summary>
        /// <code>
        /// R.Union(
        ///     new HashSet{int}() { 1, 2, 3 }, 
        ///     new HashSet{int}() { 2, 3, 4 }
        /// ); //=> { 1, 2, 3, 4 }
        /// </code>
        public static HashSet<T> Union<T>(HashSet<T> set1, HashSet<T> set2)
        {
            var newSet = new HashSet<T>(set1);
            newSet.UnionWith(set2);

            return newSet;
        }
    }
}
