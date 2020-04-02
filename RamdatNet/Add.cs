using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried Function to add two ints.
        /// </summary>
        /// <code>
        /// R.Add(1)(2); //-> 3
        /// </code>
        public static Func<int, int> Add(int a) => b => a + b;

        /// <summary>
        /// Curried Function to add two doubles.
        /// </summary>
        /// <code>
        /// R.Add(1)(2); //-> 3
        /// </code>
        public static Func<double, double> Add(double a) => b => a + b;

        /// <summary>
        /// Curried Function to add two decimals.
        /// </summary>
        /// <code>
        /// R.Add(1)(2); //-> 3
        /// </code>
        public static Func<decimal, decimal> Add(decimal a) => b => a + b;

        /// <summary>
        /// Add two ints.
        /// </summary>
        /// <code>
        /// R.Add(1, 2); //-> 3
        /// </code>
        public static int Add(int a, int b) => a + b;

        /// <summary>
        /// Add two doubles.
        /// </summary>
        /// <code>
        /// R.Add(1, 2); //-> 3
        /// </code>
        public static double Add(double a, double b) => a + b;

        /// <summary>
        /// Add two decimals.
        /// </summary>
        /// <code>
        /// R.Add(1, 2); //-> 3
        /// </code>
        public static decimal Add(decimal a, decimal b) => a + b;
    }
}