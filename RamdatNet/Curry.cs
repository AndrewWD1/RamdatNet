using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Z>> Curry<T1, T2, Z>(Func<T1, T2, Z> Fn)
            => t1 => t2 => Fn(t1, t2);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Z>>> Curry<T1, T2, T3, Z>(Func<T1, T2, T3, Z> Fn)
            => t1 => t2 => t3 => Fn(t1, t2, t3);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Z>>>> Curry<T1, T2, T3, T4, Z>(Func<T1, T2, T3, T4, Z> Fn)
            => t1 => t2 => t3 => t4 => Fn(t1, t2, t3, t4);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Z>>>>> Curry<T1, T2, T3, T4, T5, Z>(Func<T1, T2, T3, T4, T5, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => Fn(t1, t2, t3, t4, t5);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Z>>>>>> Curry<T1, T2, T3, T4, T5, T6, Z>(Func<T1, T2, T3, T4, T5, T6, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => Fn(t1, t2, t3, t4, t5, t6);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Z>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, Z>(Func<T1, T2, T3, T4, T5, T6, T7, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => Fn(t1, t2, t3, t4, t5, t6, t7);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Z>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => Fn(t1, t2, t3, t4, t5, t6, t7, t8);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Z>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Z>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Z>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Z>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Z>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Z>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Z>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        /// <summary>
        /// Returns a curried version of the passed in function.
        /// </summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, Z>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Z> Fn)
            => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
    }
}