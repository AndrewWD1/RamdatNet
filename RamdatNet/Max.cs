using System;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns the larger of two arguments that implement IComparable.
        /// </summary>
        /// <code>
        /// R.Max(789)(123); //=> 789
        /// R.Max('a')('b'); //=> 'b'
        /// </code>
        public static Func<T, T> Max<T>(T t1)
        where T : IComparable
            => t2 =>
            {
                return t1.CompareTo(t2) >= 0 ? t1 : t2;
            };

        /// <summary>
        /// Returns the larger of two arguments that implement IComparable.
        /// </summary>
        /// <code>
        /// R.Max(789, 123); //=> 789
        /// R.Max('a', 'b'); //=> 'b'
        /// </code>
        public static T Max<T>(T t1, T t2)
        where T : IComparable
        {
            return t1.CompareTo(t2) >= 0 ? t1 : t2;
        }
    }
}