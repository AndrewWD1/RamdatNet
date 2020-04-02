using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        public static Func<T, bool> PropEq<T, K>(string prop, K val)
        where K : IComparable
            => t =>
            {
                var t1 = t.GetType();
                var t2 = t1.GetProperty(prop);
                var t3 = t2.GetValue(t);
                var t4 = val.CompareTo(t3) == 0;
                return t4;
            };
    }
}