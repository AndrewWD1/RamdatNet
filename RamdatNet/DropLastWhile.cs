using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list excluding all the tailing elements of a given list which satisfy the supplied predicate function.
        /// </summary>
        /// <code>
        /// Predicate{int} lteThree = (int x) => 3 >= x;
        /// R.DropLastWhile(lteThree)( new int[] { 1, 2, 3, 4, 3, 2, 1 });
        /// //=> { 1, 2, 3, 4 }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> DropLastWhile<T>(Predicate<T> Fn)
            => list =>
            {
                var newList = list.Select(x => x).ToList();
                int i = newList.Count() - 1;
                while (Fn(newList[i]))
                {
                    newList.RemoveAt(i);
                    i -= 1;
                }
                return newList;
            };

        /// <summary>
        /// Returns a new list excluding all the tailing elements of a given list which satisfy the supplied predicate function.
        /// </summary>
        /// <code>
        /// R.DropLastWhile(x => x !== "d")("Ramda"); //=> "Ramd"
        /// </code>
        public static Func<string, string> DropLastWhile(Predicate<char> Fn)
            => list =>
            {
                var newList = list.Select(x => x).ToList();
                int i = newList.Count() - 1;
                while (Fn(newList[i]))
                {
                    newList.RemoveAt(i);
                    i -= 1;
                }
                return String.Join("", newList);
            };
    }
}