﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class TTests
    {
        [TestMethod]
        public void TTests_Docs()
        {
            Assert.IsTrue(R.T());
            Assert.IsTrue(R.T(1, 2));
            Assert.IsTrue(R.T(1, 'a'));
        }
    }
}