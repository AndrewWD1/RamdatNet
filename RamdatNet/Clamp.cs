using System;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Restricts a number to be within a range.
        /// </summary>
        /// <code>
        /// R.Clamp(1, 10)( -5) // => 1
        /// R.Clamp(1, 10)( 15) // => 10
        /// R.Clamp(1, 10)( 4)  // => 4
        /// </code>
        public static Func<int, int> Clamp(int a, int b)
            => c =>
            {
                if (c >= a && c <= b) return c;
                else if (c < a) return a;
                return b;
            };
    }
}