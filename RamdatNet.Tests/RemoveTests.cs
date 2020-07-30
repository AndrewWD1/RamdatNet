using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void RemoveTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Remove(2, 3, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }).ToArray(),
                new int[] { 1, 2, 6, 7, 8 }
            );
        }
    }
}