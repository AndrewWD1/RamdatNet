using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Returns the first element of the list which matches the predicate, or null if no element matches.
        /// </summary>
        /// <code>
        /// HasA[] xs = { new HasA(a: 1), new HasA(a: 2), new HasA(a: 3) };
        /// R.Find(R.PropEq{HasA, int}("a", 2))(xs); //=> {a: 2};
        /// R.Find(R.PropEq{HasA, int}("a", 4))(xs); //=> null;
        /// </code>
        public static Func<IEnumerable<T>, T> Find<T>(Func<T, bool> fn)
            => list => list.FirstOrDefault(fn);

        /// <summary>
        /// Returns the first element of the list which matches the predicate, or null if no element matches.
        /// </summary>
        /// <code>
        /// HasA[] xs = { new HasA(a: 1), new HasA(a: 2), new HasA(a: 3) };
        /// R.Find(R.PropEq{HasA, int}("a", 2), xs); //=> {a: 2};
        /// R.Find(R.PropEq{HasA, int}("a", 4), xs); //=> null;
        /// </code>
        public static T Find<T>(Func<T, bool> fn, IEnumerable<T> list)
            => Find(fn)(list);
    }
}