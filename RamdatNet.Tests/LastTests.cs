using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class LastTests
    {
        [TestMethod]
        public void LastTests_Docs()
        {
            R.Last(new string[] { "fi", "fo", "fum" });

            Assert.AreEqual(
                R.Last(new string[] { "fi", "fo", "fum" }),
                "fum"
            );

            Assert.ThrowsException<ArgumentException>(
                () => R.Last(new int[] { })
            );

            Assert.AreEqual(
                R.Last("abc"),
                "c"
            );

            Assert.AreEqual(
                R.Last(""),
                ""
            );
        }
    }
}