using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Combines two lists into a set (i.e. no duplicates) composed of those elements common to both lists. Note that this is not destructive, and respects the order from the second list or set.
        /// </summary>
        /// <code>
        /// R.Intersection( new int[] { 1,2,3,4 }, new int[] { 7,6,5,4,3 }); //=> { 4, 3 }
        /// </code>
        public static IList<T> Intersection<T>(IList<T> set1, IList<T> set2)
        {
            HashSet<T> setCopy = new HashSet<T>(set2);

            setCopy.IntersectWith(set1);

            return setCopy.ToList();
        }

        /// <summary>
        /// /// Combines two lists into a set (i.e. no duplicates) composed of those elements common to both lists. Note that this is not destructive, and respects the order from the second list or set.
        /// </summary>
        /// <code>
        /// R.Intersection( new HashSet{int} { 1,2,3,4 }, new HashSet{int} { 7,6,5,4,3 }); //=> { 4, 3 }
        /// </code>
        public static HashSet<T> Intersection<T>(HashSet<T> set1, HashSet<T> set2)
        {
            HashSet<T> setCopy = new HashSet<T>(set2);

            setCopy.IntersectWith(set1);

            return setCopy;
        }
    }
}