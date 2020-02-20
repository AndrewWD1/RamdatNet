using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AlwaysTest
    {
        Func<string> str = R.Always("STRING");

        Func<int> number = R.Always(1);

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