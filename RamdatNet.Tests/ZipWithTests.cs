using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ZipWithTests
    {
        [TestMethod]
        public void ZipWithTests_Docs()
        {
            Func<int, char, string> f = (x, y) => $"{x} _ {y}";
            CollectionAssert.AreEqual(
                R.ZipWith(f)(new int[] { 1, 2, 3 }, new char[] { 'a', 'b', 'c' }).ToArray(),
                new string[] { "1 _ a", "2 _ b", "3 _ c" }
            );
        }
    }
}