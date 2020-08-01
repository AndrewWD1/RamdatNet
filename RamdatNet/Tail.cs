susing System;

namespace RamdatNet
{
    public partial class R
    {
        public static IEnumerable<T> Tail<T>(IEnumerable<T> list>)
            => list.Skip(1);
    }
}
