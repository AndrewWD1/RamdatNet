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
            var t = R.Scan<int, int>((a, c) => a + c, 0)(new int[] { 1, 2, 3});
            
            CollectionAssert.AreEqual(
                t.ToArray(),
                new int[] { 0, 1, 3, 6 }
            );
        }
    }
}
