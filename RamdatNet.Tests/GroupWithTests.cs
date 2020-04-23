using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class GroupWithTests
    {
        [TestMethod]
        public void GroupWithTests_Docs()
        {
            var result =
                R.GroupWith((int x, int y) => x == y)(new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 });

            var expected = new List<List<int>> {
                new List<int> { 0 },
                new List<int> { 1, 1 },
                new List<int> { 2 },
                new List<int> { 3 },
                new List<int> { 5 },
                new List<int> { 8 },
                new List<int> { 13 },
                new List<int> { 21 }
            };
            Assert.AreEqual(result.Count(), expected.Count());
            for (int i = 0; i < result.Count(); i++)
            {
                CollectionAssert.AreEqual(expected[i], result[i]);
            }
        }
    }
}