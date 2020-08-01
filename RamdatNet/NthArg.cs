using RamdatNet.Library;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a function which returns its nth argument.
        /// </summary>
        /// <code>
        /// R.nthArg(1)('a', 'b', 'c'); //=> 'b'
        /// R.nthArg(-1)('a', 'b', 'c'); //=> 'c'
        /// </code>
        static public VariadicFunction<T, T> NthArg<T>(int n)
        {
            T fn(params T[] args)
            {
                if (n < 0) return args[args.Length + n];
                return args[n];
            }

            return fn;
        }
    }
}