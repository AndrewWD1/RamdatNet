using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ChainTests
    {
        [TestMethod]
        public void ChainTests_Docs()
        {
            Func<int, IEnumerable<int>> duplicate = n => new int[] { n, n };

            var result = R.Chain(duplicate, new int[] { 1, 2, 3 });
            var expected = new int[] { 1, 1, 2, 2, 3, 3 };

            CollectionAssert.AreEqual(expected, result.ToArray());
        }
    }
}