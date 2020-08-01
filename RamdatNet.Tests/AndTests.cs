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

            static bool func1(int x) => x > 0;
            static bool func2(int x) => x < 10;
            var f = R.And(func1, (Func<int, bool>)func2);
            Assert.IsTrue(f(5));
        }
    }
}