using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a function that always returns the given value. Note that for non-primitives the value returned is a reference to the original value.
        /// </summary>
        /// <code>
        /// var t = R.Always("Tee");
        /// t(); //-> "Tee"
        /// </code>
        public static Func<T> Always<T>(T x) => () => x;
    }
}