using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class SliceTest
    {
        [TestMethod]
        public void SliceTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Slice(1, 3, new char[] { 'a', 'b', 'c', 'd' }).ToArray(),
                new char[] { 'b', 'c' }
            );

            CollectionAssert.AreEqual(
                R.Slice(0, -1, new char[] { 'a', 'b', 'c', 'd' }).ToArray(),
                new char[] { 'a', 'b', 'c' }
            );

            Assert.AreEqual(
                R.Slice(0, 3, "ramda"),
                "ram"
            );
        }
    }
}