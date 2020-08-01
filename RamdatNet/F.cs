namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// A function that always returns false.
        /// </summary>
        /// <code>
        /// R.F(); //=> false
        /// </code>
        public static bool F() => false;

        /// <summary>
        /// A function that always returns false.
        /// </summary>
        /// <code>
        /// R.F(); //=> false
        /// </code>
        public static bool F(object t) => false;

        /// <summary>
        /// A function that always returns false.
        /// </summary>
        /// <code>
        /// R.F(); //=> false
        /// </code>
        public static bool F(params object[] t) => false;
    }
}