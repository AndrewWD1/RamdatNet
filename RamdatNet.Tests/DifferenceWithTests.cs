using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DifferenceWithTests
    {
        [TestMethod]
        public void DifferenceWithTests_Docs()
        {
            var set1 = new HashSet<int> { 1, 2, 3, 4 };
            var set2 = new HashSet<int> { 7, 6, -2, 4, 3 };
            Func<int, int, bool> cmp = (x, y)
                => Math.Abs(x) == Math.Abs(y);
            CollectionAssert.AreEqual(R.DifferenceWith(cmp)(set1, set2).ToArray(), new int[] { 1 });
        }
    }
}