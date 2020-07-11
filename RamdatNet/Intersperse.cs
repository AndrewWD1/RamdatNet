using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Creates a new list with the separator interposed between elements. Dispatches to the intersperse method of the second argument, if present.
        /// </summary>
        /// <code>
        /// R.Intersperse('a')( new char[] { 'b', 'n', 'n', 's' }); //=> { 'b', 'a', 'n', 'a', 'n', 'a', 's' }
        /// </code> 
        public static Func<IList<T>, IList<T>> Intersperse<T>(T t)
            => list =>
            {
                if (list.Count == 0) return new T[0];

                var newList = new T[2 * list.Count - 1];

                for (int i = 0; i < newList.Count(); i++)
                {
                    if (i % 2 == 0)
                        newList[i] = list[i / 2];
                    else
                        newList[i] = t;
                }

                return newList;
            };

        /// <summary>
        /// Creates a new list with the separator interposed between elements. Dispatches to the intersperse method of the second argument, if present.
        /// </summary>
        /// <code>
        /// R.Intersperse('a')( new char[] { 'b', 'n', 'n', 's' }); //=> { 'b', 'a', 'n', 'a', 'n', 'a', 's' }
        /// </code> 
        public static IList<T> Intersperse<T>(T t, IList<T> list)
            => Intersperse(t)(list);
    }
}