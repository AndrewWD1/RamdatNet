using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list containing the first n elements of a given list, passing each value to the supplied predicate function, and terminating when the predicate function returns false. Excludes the element that caused the predicate function to fail. The predicate function is passed one argument.
        /// </summary>
        /// <code>
        /// static int isNotFour(int x) => x != 4;
        /// R.TakeWhile(isNotFour, new int[] { 1, 2, 3, 4, 3, 2, 1 }); //=> { 1, 2, 3 }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> TakeWhile<T>(Func<T, bool> fn)
            => list => list.TakeWhile(fn);

        /// <summary>
        /// Returns a new list containing the first n elements of a given list, passing each value to the supplied predicate function, and terminating when the predicate function returns false. Excludes the element that caused the predicate function to fail. The predicate function is passed one argument.
        /// </summary>
        /// <code>
        /// R.TakeWhile(x => x != 'd' , "Ramda"); //=> "Ram"
        /// </code>
        public static Func<string, string> TakeWhile(Func<char, bool> fn)
            => str => String.Join("", str.ToCharArray().TakeWhile(fn));
    }
}