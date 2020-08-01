using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Takes a list and returns a list of lists where each sublist's elements are all satisfied pairwise comparison according to the provided function. Only adjacent elements are passed to the comparison function.
        /// </summary>
        /// <code>
        /// R.GroupWith(R.Equals)( { 0, 1, 1, 2, 3, 5, 8, 13, 21 })
        /// //=> {{0}, {1, 1}, {2}, {3}, {5}, {8}, {13}, {21}}
        /// </code>
        public static Func<IList<T>, List<List<T>>> GroupWith<T>(Func<T, T, bool> fn)
            => list =>
            {
                List<List<T>> newList = new List<List<T>>();

                int i = 0;
                while (i < list.Count())
                {
                    List<T> subList = new List<T> { list[i] };
                    i += 1;
                    while (i < list.Count() && fn(list[i - 1], list[i]))
                    {
                        subList.Add(list[i]);
                        i += 1;
                    }
                    newList.Add(subList);
                }

                return newList;
            };

        /// <summary>
        /// Takes a list and returns a list of lists where each sublist's elements are all satisfied pairwise comparison according to the provided function. Only adjacent elements are passed to the comparison function.
        /// </summary>
        /// <code>
        /// R.GroupWith(R.Equals, { 0, 1, 1, 2, 3, 5, 8, 13, 21 })
        /// //=> {{0}, {1, 1}, {2}, {3}, {5}, {8}, {13}, {21}}
        /// </code>
        public static List<List<T>> GroupWith<T>(Func<T, T, bool> fn, List<T> list)
        {
            List<List<T>> newList = new List<List<T>>();

            int i = 0;
            while (i < list.Count())
            {
                List<T> subList = new List<T> { list[i] };
                i += 1;
                while (i < list.Count() && fn(list[i - 1], list[i]))
                {
                    subList.Add(list[i]);
                    i += 1;
                }
                newList.Add(subList);
            }

            return newList;
        }
    }
}