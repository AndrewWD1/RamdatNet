using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Accepts a function fn and returns a function that guards invocation of fn such that fn can only ever be called once, no matter how many times the returned function is invoked. The first value calculated is returned in subsequent invocations.
        /// </summary>
        /// <code>
        /// Func{int, int} addOneOnce = R.Once((int x) => x + 1);
        /// addOneOnce(10); //=> 11
        /// addOneOnce(addOneOnce(50)); //=> 11
        /// </code>
        public static Func<T, K> Once<T, K>(Func<T, K> fn)
        {
            bool called = false;
            K val = default;

            return x =>
            {
                if (!called)
                {
                    called = true;
                    val = fn(x);
                    return val;
                };
                return val;
            };
        }
    }
}