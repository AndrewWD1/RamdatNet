using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a fixed list of size n containing a specified identical value.
        /// </summary>
        /// <code>
        /// R.Repeat("hi", 5); //=> { "hi", "hi", "hi", "hi", "hi" }
        /// </code>
        public static IList<T> Repeat<T>(T t, int n)
        {
            T[] list = new T[n];
            return list.Select(n => t).ToList();
        }
    }
}