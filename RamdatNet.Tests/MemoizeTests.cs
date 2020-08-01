using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RamdatNet.Tests
{
    [TestClass]
    public class MemoizeTests
    {
        [TestMethod]
        public void MemoizeTests_Docs()
        {
            int count = 0;
            Func<int, int> factorial = R.Memoize<int, int>(n =>
            {
                count += 1;
                return R.Reduce((a, c) => a * c, 1, (R.Range(1, n + 1)));
            });
            Assert.AreEqual(factorial(5), 120);
            Assert.AreEqual(factorial(5), 120);
            Assert.AreEqual(factorial(5), 120);
            Assert.AreEqual(count, 1);
        }
    }
}