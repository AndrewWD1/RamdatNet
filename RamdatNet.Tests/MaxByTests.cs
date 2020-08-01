using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RamdatNet.Tests
{
    [TestClass]
    public class MaxByTests
    {
        [TestMethod]
        public void MaxByTests_Docs()
        {
            Func<int, int> square = n => n * n;

            Assert.AreEqual(
                R.MaxBy(square)(-3, 2),
                -3
            );

            Assert.AreEqual(
                R.Reduce(R.MaxBy(square), 0, new int[] { 3, -5, 4, 1, -2 }),
                -5
            );

            Assert.AreEqual(
                R.Reduce(R.MaxBy(square), 0, new int[] { }),
                0
            );
        }
    }
}