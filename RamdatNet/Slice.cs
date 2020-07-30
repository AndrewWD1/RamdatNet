using System;
using System.Linq;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        public static IList<T> Slice<T>(int a, int b, IList<T> list)
        {
            var newList = new List<T>();

            if (a < b) return newList;

            var _a = (a % list.Count());
            var _b = (b % list.Count());

            for (int i= _a; i < _b; i++)
            {
                newList.Add(list[i]);
            }
            
            return newList;
        }
    }
}
