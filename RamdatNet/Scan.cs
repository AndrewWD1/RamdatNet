using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Scan is similar to reduce, but returns a list of successively reduced values from the left
        /// </summary>
        /// <code>
        /// var numbers = new int[] { 1, 2, 3, 4 };
        /// var factorials = R.Scan(R.Multiply, 1, numbers); //=> { 1, 1, 2, 6, 24 }
        /// </code>
        public static List<K> Scan<T, K>(Func<T, K, K> reducer, K initial, IList<T> list)
        {
            var scan = new List<K>(new K[] { initial });

            for (int i = 0; i < list.Count(); i++)
            {
                var last = scan[scan.Count - 1];
                scan.Add(reducer(list[i], last));
            }

            return scan;
        }
    }
}