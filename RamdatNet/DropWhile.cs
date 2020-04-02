using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list excluding the leading elements of a given list which satisfy the supplied predicate function.
        /// </summary>
        /// <code>
        /// Predicate{int} LteTwo = x => 2 >= x;
        /// R.DropWhile(LteTwo)( { 1, 2, 3, 4, 3, 2, 1 });
        /// //=> { 3, 4, 3, 2, 1 }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> DropWhile<T>(Predicate<T> Fn)
            => e =>
            {
                var prevList = e.ToList();
                var newList = new List<T>();

                int i = 0;
                while (Fn(prevList[i]))
                    i += 1;

                return e.Skip(i);
            };

        /// <summary>
        /// Returns a new list excluding the leading elements of a given list which satisfy the supplied predicate function.
        /// </summary>
        /// <code>
        /// R.dropWhile(x => x !== 'd' , 'Ramda');
        /// //=> 'da'
        /// </code>
        public static Func<string, string> DropWhile(Predicate<char> Fn)
            => str =>
            {
                var prevList = str.ToCharArray();
                var newList = new List<char>();

                int i = 0;
                while (Fn(prevList[i]))
                    i += 1;

                return String.Join("", str.Skip(i));
            };
    }
}