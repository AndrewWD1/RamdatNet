using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ZipTests
    {
        [TestMethod]
        public void ZipTests_Docs()
        {
            CollectionAssert.AreEqual(
                    R.Zip(new int[] { 1, 2, 3 }, new char[] { 'a', 'b', 'c' }).ToArray(),
                    new (int, char)[] { (1, 'a'), (2, 'b'), (3, 'c') }

            );
        }
    }
}