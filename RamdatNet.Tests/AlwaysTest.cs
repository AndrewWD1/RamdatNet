using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AlwaysTest
    {
        private readonly Func<string> str = R.Always("STRING");
        private readonly Func<int> number = R.Always(1);

        [TestMethod]
        public void AlwaysTest_multiple_tests()
        {
            Func<Func<int>> function = R.Always(number);

            Assert.AreEqual(str(), "STRING");
            Assert.AreEqual(number(), 1);
            Assert.AreEqual(function(), number);
            Assert.AreEqual(function()(), 1);
        }
    }
}