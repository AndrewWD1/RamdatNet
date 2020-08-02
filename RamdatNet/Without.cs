using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// O(n).
        /// </summary>
        /// <code>
        ///
        /// </code>
        public Func<IList<T>, IList<T>> Without<T>(IList<T> drop)
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