using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        public static Func<IList<T>, IList<K>> Scan<T, K>(Func<T,K, K> reducer, K initial)
            => list =>
            {
                var scan = new List<K>(new K[] {initial});

                for (int i = 0; i < list.Count(); i++)
                {
                    var last = scan[scan.Count - 1];
                    scan.Add(reducer(list[i], last));
                }

                return scan;
            };
    }
}
