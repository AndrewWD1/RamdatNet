using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns true if both arguments are true; false otherwise.
        /// </summary>
        /// <code>
        /// R.And(true, true); //=> true
        /// R.And(true, false); //=> false
        /// R.And(false, true); //=> false
        /// R.And(false, false); //=> false
        /// </code>
        public static bool And(bool a, bool b) => a && b;

        /// <summary>
        /// Returns true if both arguments are true; false otherwise.
        /// </summary>
        /// <code>
        /// Func{int, bool} func1 = x => x > 0;
        /// Func{int, bool} func2 = x => x < 10;
        /// var f = R.And(func1, func2);
        /// f(5) //=> true
        /// </code>
        public static Func<T, bool> And<T>(Func<T, bool> a, Func<T, bool> b)
            => t => a(t) && b(t);
    }
}