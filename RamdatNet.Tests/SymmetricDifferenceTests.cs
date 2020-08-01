using System;
using RamdatNet;
using Microsoft.VisualStudio

namespace RamdatNet.Tests
{
    [TestClass]
    public class SymmetricDifferenceTests
    {
        [TestMethod]
        public void SymmetricDifferenceTeats_Docs()
        {
            var t1 = new HashSet<int>(new int[] { 1, 2, 3, 4 });
            var t2 = new HashSet<int>(new int[] { 7, 6, 5, 4 });

            CollectionAssert.AreEqual(
                R.SymmetricDifference(t1, t2).ToArray(),
                new int[] { 1, 2, 3, 7, 6, 5 }
            );
        }
    }
}
