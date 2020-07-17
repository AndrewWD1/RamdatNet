using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class NoneTests
    {
        [TestMethod]
        public void NoneTests_Docs()
        {
            static bool isEven(int n) => n % 2 == 0;
            static bool isOdd(int n) => n % 2 == 1;
            Assert.IsTrue(R.None((Predicate<int>)isEven)(new int[] { 1, 3, 5, 7, 9, 11 }));
            Assert.IsFalse(R.None((Predicate<int>)isOdd)(new int[] { 1, 3, 5, 7, 8, 11 }));
        }
    }
}