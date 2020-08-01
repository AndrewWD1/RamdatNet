using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Retrieve the value at a given path.
        /// </summary>
        /// <code>
        /// R.Path(new string[] { "a", "b" })(new {a = new {b = 2}}); //=> 2
        /// </code>
        public static Func<object, object> Path(IList<string> path)
            => obj =>
            {
                var curr = R.Prop(path[0])(obj);
                foreach (string p in path.Skip(1))
                {
                    curr = R.Prop(p)(curr);
                    if (curr == null) return null;
                }

                return curr;
            };

        /// <summary>
        /// Retrieve the value at a given path.
        /// </summary>
        /// <code>
        /// R.Path(new string[] { "a", "b" })(new {a = new {b = 2}}); //=> 2
        /// </code>
        public static Func<object, T> Path<T>(IList<string> path)
            => obj =>
            {
                var curr = R.Prop(path[0])(obj);
                foreach (string p in path.Skip(1))
                {
                    curr = R.Prop(p)(curr);
                    if (curr == null) return default;
                }

                return (T)curr;
            };
    }
}