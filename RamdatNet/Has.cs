using System;

namespace RamdatNet
{
    public partial class R
    {
        public static Func<T, bool> Has<T>(string prop)
            => t =>
            {
                return t.GetType().GetProperty(prop) != null;
            };
        public static Func<object, bool> Has(string prop)
            => t =>
            {
                return t.GetType().GetProperty(prop) != null;
            };
    }
}