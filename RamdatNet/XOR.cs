using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Exclusive disjunction logical operation. Returns true if one of the arguments is true and the other is false. Otherwise, it returns false.
        /// </summary>
        /// <code>
        /// R.XOR(true, true); //=> false
        /// R.XOR(true, false); //=> true
        /// R.XOR(false, true); //=> true
        /// R.XOR(false, false); //=> false
        /// </code>
        public static bool XOR(bool a, bool b) => (a && !b) || (!a && b);

        /// <summary>
        /// Exclusive disjunction logical operation. Returns true if one of the arguments is true and the other is false. Otherwise, it returns false.
        /// </summary>
        /// <code>
        /// Func{int, bool} func1 = x => x > 0;
        /// Func{int, bool} func2 = x => x < 0;
        /// var f = R.XOR(func1, func2);
        /// f(5) //=> true
        /// </code>
        public static Func<T, bool> XOR<T>(Func<T, bool> fn1, Func<T, bool> fn2)
            => t => XOR(fn1(t), fn2(t));
    }
}