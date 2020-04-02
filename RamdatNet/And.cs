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
    }
}