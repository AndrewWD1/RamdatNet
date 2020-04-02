using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a list containing all but the last n elements of the given list.
        /// </summary>
        /// <code>
        /// R.Drop(1)( new string[] { "foo", "bar", "baz" });
        ///   //=> { "foo", "bar" }
        /// R.Drop(2)( new string[] { "foo", "bar", "baz" });
        ///   //=> { "foo" }
        /// R.Drop(4)( new string[] { "foo", "bar", "baz" });
        ///   //=> {  }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> DropLast<T>(int i)
            => list => list.Take(list.Count() - i);

        /// <summary>
        /// Returns a list containing all but the last n elements of the given list.
        /// </summary>
        /// <code>
        /// R.Drop(3)("ramda"); //=> "ra"
        /// </code>
        public static Func<string, string> DropLast(int i)
            => list => String.Join("", list.Take(list.Count() - i));
    }
}