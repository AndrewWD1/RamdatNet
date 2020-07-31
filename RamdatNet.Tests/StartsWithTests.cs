using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class StartsWithTests
    {
        [TestMethod]
        public void StartsWithTests_Docs()
        {
            Assert.IsTrue(
                R.StartsWith(new char[] { 'a' })(new char[] { 'a', 'b', 'c' })
            );

            Assert.IsFalse(
                R.StartsWith(new char[] { 'b' })(new char[] { 'a', 'b', 'c' })
            );

            Assert.IsTrue(
                R.StartsWith("a")("abc")
            );

            Assert.IsFalse(
                R.StartsWith("b")("abc")
            );
        }
    }
}