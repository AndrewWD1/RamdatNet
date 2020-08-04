using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class UniqTests
    {
        [TestMethod]
        public void UniqTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Uniq(new int[] { 1, 1, 2, 1 }).ToArray(),
                new int[] { 1, 2 }
            );
        }
    }
}