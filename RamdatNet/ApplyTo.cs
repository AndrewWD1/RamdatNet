using System;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Takes a value and applies a function to it.
        /// </summary>
        /// <code>
        /// var t42 = R.ApplyTo{int, int}(42);
        /// t42(R.Add(1)); //-> 43
        /// </code>
        public static Func<Func<T, K>, K> ApplyTo<T, K>(T t)
            => fn => fn(t);
    }
}