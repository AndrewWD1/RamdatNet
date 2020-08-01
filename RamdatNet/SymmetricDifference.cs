using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        public static HashSet<T> SymmetricDifference<T>(HashSet<T> set1, HashSet<T> set2)
        {
            var s = Difference(set1, set2);
            s.UnionWith(Difference(set2, set1));

            return s;
        }
    }
}