using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Takes a function and two values in its domain and returns true if the values map to the same value in the codomain; false otherwise.
        /// </summary>
        /// <code>
        /// R.EqBy(Math.Abs, 5, -5);
        /// //=> true
        /// </code>
        public static Func<T, T, bool> EqBy<T>(Func<T, T> Fn)
            => (x, y) => Fn(x).Equals(Fn(y));
    }
}