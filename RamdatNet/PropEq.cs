using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        public static Func<K, bool> PropEq<K, T>(string prop, T val)
        where T : IComparable
            => t =>
            {
                var foundVal = Prop(prop)(t);
                return val.CompareTo(foundVal) == 0;
            };

        public static Func<object, bool> PropEq<T>(string prop, T val)
        where T : IComparable
            => t =>
            {
                var foundVal = Prop(prop)(t);
                return val.CompareTo(foundVal) == 0;
            };
    }
}