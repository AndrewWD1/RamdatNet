using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class XORTests
    {
        [TestMethod]
        public void XORTests_Docs()
        {
            Assert.IsFalse(R.XOR(true, true)); //=> false
            Assert.IsTrue(R.XOR(true, false)); //=> true
            Assert.IsTrue(R.XOR(false, true)); //=> true
            Assert.IsFalse(R.XOR(false, false)); //=> false

            Func<int, bool> func1 = x => x > 0;
            Func<int, bool> func2 = x => x < 0;
            var f = R.XOR(func1, func2);
            Assert.IsTrue(f(5));
        }
    }
}
