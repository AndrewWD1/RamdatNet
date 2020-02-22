using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DifferenceTests
    {
        [TestMethod]
        public void DifferenceTest_Docs()
        {
            var set1 = new HashSet<int> { 1, 2, 3, 4 };
            var set2 = new HashSet<int> { 7, 6, 5, 4, 3 };
            CollectionAssert.AreEqual(R.Difference(set1, set2).ToArray(), new int[] { 1, 2 });
        }
    }
}