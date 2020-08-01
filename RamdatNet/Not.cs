using System;

namespace RamdatNet
{
    public partial class R
    {
        public static bool Not(bool val)
            => !val;

        public static Func<T, bool> Not<T>(Func<T, bool> fn)
            => R.Compose(R.Not, fn);
    }
}