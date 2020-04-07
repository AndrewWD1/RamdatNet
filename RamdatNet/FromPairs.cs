using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        public static Dictionary<T, K> FromPairs<T, K>((T, K)[] pairs)
        {
            Dictionary<T, K> newPairs = new Dictionary<T, K>();

            foreach (var pair in pairs)
            {
                newPairs[pair.Item1] = pair.Item2;
            }

            return newPairs;
        }
        public static Dictionary<object, object> FromPairs(object[][] pairs)
        {
            Dictionary<object, object> newPairs = new Dictionary<object, object>();

            foreach (var pair in pairs)
            {
                newPairs[pair[0]] = pair[1];
            }

            return newPairs;
        }

    }
}