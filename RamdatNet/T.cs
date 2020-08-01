namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// A function that always returns true. Any passed in parameters are ignored.
        /// </summary>
        public static bool T()
            => true;

        /// <summary>
        /// A function that always returns true. Any passed in parameters are ignored.
        /// </summary>
        public static bool T(params object[] args)
            => true;
    }
}