using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class UnionTests
    {
        [TestMethod]
        public void UnionTests_Docs_Lists()
        {
            CollectionAssert.AreEqual(
                R.Union(
                    new int[] { 1, 2, 3 },
                    new int[] { 2, 3, 4 }
                ).ToList(),
                new int[] { 1, 2, 3, 4 }
            );
        }

        [TestMethod]
        public void UnionTests_Docs_Sets()
        {
            CollectionAssert.AreEqual(
                R.Union(
                    new HashSet<int>() { 1, 2, 3 },
                    new HashSet<int>() { 2, 3, 4 }
                ).ToList(),
                new HashSet<int>() { 1, 2, 3, 4 }.ToList()
            );
        }
    }
}
