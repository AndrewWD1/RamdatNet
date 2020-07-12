using System;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns the larger of two arguments that implement IComparable.
        /// </summary>
        /// <code>
        /// Func{int, int} square = n => n * n;
        /// R.MaxBy(square)(-3, 2); //=> -3
        /// R.Reduce(R.MaxBy(square), 0, new int[] { 3, -5, 4, 1, -2 }); //=> -5
        /// R.Reduce(R.MaxBy(square), 0, new int[] { }); //=> 0
        /// </code>
        public static Func<T, T, T> MaxBy<T>(Func<T, T> fn)
        where T : IComparable
            => (t1, t2) =>
            {
                return fn(t1).CompareTo(fn(t2)) >= 0 ? t1 : t2;
            };
    }
}