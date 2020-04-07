using System;
using RamdatNet.Library;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new function much like the supplied one, except that the first two arguments' order is reversed.
        /// </summary>
        /// <code>
        /// 
        /// </code>
        public static Func<K, T, Z> Flip<T, K, Z>(Func<T, K, Z> fn)
            => (x, y) => fn(y, x);

        /// <summary>
        /// Returns a new function much like the supplied one, except that the first two arguments' order is reversed.
        /// </summary>
        /// <code>
        /// int[] mergeThree(params int[] args)
        /// {
        ///     return args;
        /// }
        /// R.Flip{int, int[]}(mergeThree)(1, 2, 3) // => { 2, 1, 3}
        /// </code>
        public static SpreadFunction<T, K> Flip<T, K>(SpreadFunction<T, K> fn)
        {
            K NewFunction(params T[] args)
            {
                if (args.Length == 0) return fn(args);
                if (args.Length == 1) return fn(args);
                else
                {
                    T[] newArgs = new T[args.Length];
                    Array.Copy(args, newArgs, args.Length);
                    T temp = newArgs[0];
                    newArgs[0] = newArgs[1];
                    newArgs[1] = temp;
                    return fn(newArgs);
                }
            }

            return NewFunction;
        }

        /// <summary>
        /// Returns a new function much like the supplied one, except that the first two arguments' order is reversed.
        /// </summary>
        /// <code>
        /// 
        /// </code>
        public static SpreadFunction Flip(SpreadFunction fn)
        {
            object NewFunction(params object[] args)
            {
                if (args.Length == 0) return fn(args);
                if (args.Length == 1) return fn(args);
                else
                {
                    object[] newArgs = new object[args.Length];
                    Array.Copy(args, newArgs, args.Length);
                    object temp = args[0];
                    args[0] = args[1];
                    args[1] = temp;
                    return fn(newArgs);
                }
            }

            return NewFunction;
        }
    }
}