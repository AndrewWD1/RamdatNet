using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AndTests
    {
        [TestMethod]
        public void AndTests_tests()
        {
            Assert.IsTrue(R.And(true, true));
            Assert.IsFalse(R.And(true, false));
            Assert.IsFalse(R.And(false, true));
            Assert.IsFalse(R.And(false, false));

            Func<int, bool> func1 = x => x > 0;
            Func<int, bool> func2 = x => x < 10;
            var f = R.And(func1, func2);
            Assert.IsTrue(f(5));
        }
    }
}