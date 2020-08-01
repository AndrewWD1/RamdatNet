using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns the last element of the list which matches the predicate, or null if no element matches and type T is nullable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fn"></param>
        /// <exception cref="Exception">If not found and type is non-nullable</exception>
        /// <returns></returns>
        public static Func<IList<T>, T> FindLast<T>(Func<T, bool> fn)
            => list =>
            {
                for (int i = list.Count() - 1; i >= 0; i--)
                {
                    if (fn(list[i]))
                        return list[i];
                }
                // Checks whether type is nullable
                if (default(T) == null)
                    return default;

                throw new Exception("T is non-nullable and was not found");
            };

        /// <summary>
        /// Returns the last element of the list which matches the predicate, or null if no element matches and type T is nullable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fn"></param>
        /// <exception cref="Exception">If not found and type is non-nullable</exception>
        /// <returns></returns>
        public static T FindLast<T>(Func<T, bool> fn, IList<T> list)
            => FindLast(fn)(list);
    }
}