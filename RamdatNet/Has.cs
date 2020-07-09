using System;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns whether or not an object has an own property with the specified nam
        /// </summary>
        /// <code>
        /// HasAB o = new HasAB(1, 2);
        /// var result1 = R.Has("A")(o); //=> true
        /// var result2 = R.Has{HasAB}("B")(o); //=> true
        /// var result3 = R.Has("C")(o); //=> false
        /// </code>
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