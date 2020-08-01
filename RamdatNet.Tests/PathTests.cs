using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class PathTests
    {
        [TestMethod]
        public void PathTests_Docs()
        {
            Assert.AreEqual(
                R.Path(new string[] { "a", "b" })(new { a = new { b = 2 } }),
                2
            );
        }
    }
}