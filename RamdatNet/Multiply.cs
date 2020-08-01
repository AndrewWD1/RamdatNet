using System;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        public static Func<int, int> Multiply(int x) => y => x * y;

        public static Func<double, double> Multiply(double x) => y => x * y;

        public static Func<decimal, decimal> Multiply(decimal x) => y => x * y;

        public static int Multiply(int x, int y) => x * y;

        public static double Multiply(double x, double y) => x * y;

        public static decimal Multiply(decimal x, decimal y) => x * y;

        public static int Multiply(params int[] list) => list.Aggregate((a, c) => a * c);

        public static double Multiply(params double[] list) => list.Aggregate((a, c) => a * c);

        public static decimal Multiply(params decimal[] list) => list.Aggregate((a, c) => a * c);
    }
}