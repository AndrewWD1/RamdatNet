using RamdatNet.Library;
using System;

namespace RamdatNet
{
    public partial class R
    {
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
        public static VariadicFunction<T, K> Flip<T, K>(VariadicFunction<T, K> fn)
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
        public static VariadicFunction Flip(VariadicFunction fn)
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

        /// <summary>
        /// Returns a new function much like the supplied one, except that the first two arguments' order is reversed.
        /// </summary>
        /// <code>
        ///
        /// </code>
        public static Func<T2, Func<T1, Z>> Flip<T1, T2, Z>(Func<T1, T2, Z> fn)
            => t2 => t1 => fn(t1, t2);

        public static Func<T2, Func<T1, Func<T3, Z>>> Flip<T1, T2, T3, Z>(Func<T1, T2, T3, Z> Fn)
            => t2 => t1 => t3 => Fn(t1, t2, t3);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Z>>>> Flip<T1, T2, T3, T4, Z>(Func<T1, T2, T3, T4, Z> Fn)
            => t2 => t1 => t3 => t4 => Fn(t1, t2, t3, t4);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Z>>>>> Flip<T1, T2, T3, T4, T5, Z>(Func<T1, T2, T3, T4, T5, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => Fn(t1, t2, t3, t4, t5);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Z>>>>>> Flip<T1, T2, T3, T4, T5, T6, Z>(Func<T1, T2, T3, T4, T5, T6, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => Fn(t1, t2, t3, t4, t5, t6);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Z>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, Z>(Func<T1, T2, T3, T4, T5, T6, T7, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => Fn(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Z>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => Fn(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Z>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Z>>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Z>>>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Z>>>>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Z>>>>>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Z>>>>>>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Z>>>>>>>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        /// Returns a curried version of the passed in function with the first two parameters swapped.
        /// </summary>
        public static Func<T2, Func<T1, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, Z>>>>>>>>>>>>>>>> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Z> Fn)
            => t2 => t1 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
    }
}