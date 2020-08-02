using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class XProdTests
    {
        [TestMethod]
        public void XProdTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.XProd(new int[] { 1, 2 }, new char[] { 'a', 'b' }).ToArray(),
                new (int, char)[] { (1, 'a'), (1, 'b'), (2, 'a'), (2, 'b') }
            );
        }
    }
}