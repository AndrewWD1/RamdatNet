using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Inserts the supplied element into the list, at the specified index. Note that this is not destructive: it returns a copy of the list with the changes.  
        /// </summary>
        /// <code>
        /// R.Intersection( new HashSet{int} { 1,2,3,4 }, new HashSet{int} { 7,6,5,4,3 }); //=> { 4, 3 }  
        /// </code>
        public static HashSet<T> Intersection<T>(HashSet<T> set1, HashSet<T> set2)
        {
            HashSet<T> setCopy = new HashSet<T>(set1);

            setCopy.IntersectWith(set2);

            return setCopy;
        }
        /// <summary>
        /// Inserts the supplied element into the list, at the specified index. Note that this is not destructive: it returns a copy of the list with the changes.  
        /// </summary>
        /// <code>
        /// R.Intersection( new int[] { 1,2,3,4 }, new int[] { 7,6,5,4,3 }); //=> { 4, 3 }  
        /// </code>
        public static IList<T> Intersection<T>(IList<T> set1, IList<T> set2)
        {
            HashSet<T> setCopy = new HashSet<T>(set1);

            setCopy.IntersectWith(set2);

            return setCopy.ToList();
        }
    }
}