using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet.Tests.TestDoubles;

namespace RamdatNet.Tests
{
    [TestClass]
    public class HeadTests
    {
        [TestMethod]
        public void HeadTests_Docs()
        {
            var t1 = R.Head(new string[] { "fi", "fo", "fum" }); //=> "fi"
            Action t2 = () => R.Head(new int[] { }); //=> undefined
            var t3 = R.Head("abc"); //=> "a"
            var t4 = R.Head(""); //=> ""

            Assert.AreEqual(t1, "fi");
            Assert.ThrowsException<ArgumentException>(t2);
            Assert.AreEqual(t3, "a");
            Assert.AreEqual(t4, "");
        }
    }
}