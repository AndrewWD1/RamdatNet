using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns all but the first n elements of the given IEnumerable
        /// </summary>
        /// <code>
        /// R.Drop(1)( new string[] { "foo", "bar", "baz" });
        ///   //=> { "bar", "baz" }
        /// R.Drop(2)( new string[] { "foo", "bar", "baz" });
        ///   //=> { "baz" }
        /// R.Drop(4)( new string[] { "foo", "bar", "baz" });
        ///   //=> {  }
        /// </code>
        public static Func<IEnumerable<T>, IEnumerable<T>> Drop<T>(int i)
            => list => list.Skip(i);

        /// <summary>
        /// Returns all but the first n elements of the given IEnumerable
        /// </summary>
        /// <code>
        /// R.Drop(3)( "ramda"); //=> "da"
        /// </code>
        public static Func<string, string> Drop(int i)
            => list => String.Join("", list.Skip(i));
    }
}