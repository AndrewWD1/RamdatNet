using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ComposeTests
    {
        [TestMethod]
        public void ComposeTest_Docs()
        {
            Func<int, int> composed
                = R.Compose(new Func<int, int>[] {
                    x => x + 1,
                    x => x % 7
                });
            var result1 = composed(8);
            var result2 = composed(6);
            Assert.AreEqual(2, result1); //-> 2
            Assert.AreEqual(7, result2); //-> 7
        }
    }
}