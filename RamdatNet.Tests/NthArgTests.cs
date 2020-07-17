using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class NthArgTests
    {
        [TestMethod]
        public void NthArgTests_Docs()
        {
            Assert.AreEqual(R.NthArg<char>(1)('a', 'b', 'c'), 'b');
            Assert.AreEqual(R.NthArg<char>(-1)('a', 'b', 'c'), 'c');
        }
    }
}