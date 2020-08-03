using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// O(n). Returns a new list without values in the first argument.
        /// </summary>
        /// <code>
        /// R.Without(new int[] { 1, 2 })(new int[] { 1, 2, 1, 3, 4 }); //=> { 3, 4 }
        /// </code>
        public static Func<IList<T>, IList<T>> Without<T>(IList<T> drop)
            => list =>
            {
                HashSet<T> set = new HashSet<T>(drop);

                var newList = new List<T>(list);

                int i = 0;
                while (i < newList.Count())
                {
                    if (set.Contains(newList[i]))
                    {
                        newList.RemoveAt(i);
                    }
                    else
                        i += 1;
                }

                return newList;
            };
    }
}