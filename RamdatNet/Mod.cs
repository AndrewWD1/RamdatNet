using System;

namespace RamdatNet
{
    public partial class R
    {
        public static int Mod(int num, int mod)
        {
            if (mod <= 0) throw new ArgumentOutOfRangeException();

            return num < 0 ? (num % mod) + mod : num % mod;
        }
    }
}