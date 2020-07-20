using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Takes a predicate and a list and returns the pair of lists of the same type of elements which do and do not satisfy, the predicate, respectively.
        /// </summary>
        /// <code>
        /// R.Partition(R.Includes("s"))( new string[] { "sss", "ttt", "foo", "bars" });
        /// // => { { "sss", "bars" },  { "ttt", "foo" } }
        /// </code>
        public static Func<IList<T>, IList<IList<T>>> Partition<T>(Func<T, bool> fn)
            => list =>
            {
                IList<T> list1 = list.Where(fn).ToList();
                IList<T> list2 = list.Where(Not(fn)).ToList();

                return new List<IList<T>> { list1, list2 };
            };
    }
}