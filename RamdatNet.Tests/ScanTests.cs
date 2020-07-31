using System;
using RamdatNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ScanTests
    {
        [TestMethod]
        public void ScanTests_Docs()
        {
            var numbers = new int[] { 1, 2, 3, 4 };
            var factorials = R.Scan<int, int>(R.Multiply, 1, numbers);

            CollectionAssert.AreEqual(
                factorials.ToArray(),
                new int[] { 1, 1, 2, 6, 24 }
            );
        }
    }
}