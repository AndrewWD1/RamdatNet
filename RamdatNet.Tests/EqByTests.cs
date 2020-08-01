using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RamdatNet.Tests
{
    [TestClass]
    public class EqByTests
    {
        [TestMethod]
        public void EqByTests_Docs()
        {
            var result = R.EqBy<int>(Math.Abs)(5, -5);
            var expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}