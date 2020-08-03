using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class WithoutTests
    {
        [TestMethod]
        public void WithoutTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Without(new int[] { 1, 2 })(new int[] { 1, 2, 1, 3, 4 }).ToArray(),
                new int[] { 3, 4 }
            );
        }
    }
}