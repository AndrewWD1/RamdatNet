using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Removes the sub-list of list starting at index start and containing count elements. Note that this is not destructive: it returns a copy of the list with the changes.
        /// </summary>
        /// <code>
        /// R.Remove(2, 3, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }); //=> { 1, 2, 6, 7, 8 }
        /// </code>
        public static IList<T> Remove<T>(int start, int end, IList<T> list)
        {
            List<int> newList = new List<int>((IEnumerable<int>)list);

            for (int i = end; 0 < i; i--)
                newList.RemoveAt(start);

            return (IList<T>)newList;
        }
    }
}