using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class OnceTests
    {
        [TestMethod]
        public void OnceTests_Docs()
        {
            Func<int, int> addOneOnce = R.Once((int x) => x + 1);
            Assert.AreEqual(addOneOnce(10), 11);
            Assert.AreEqual(addOneOnce(addOneOnce(50)), 11);
        }
    }
}