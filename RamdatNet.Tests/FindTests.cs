using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet.Tests.TestDoubles;

namespace RamdatNet.Tests
{
    [TestClass]
    public class FindTests
    {
        [TestMethod]
        public void FindTests_Docs()
        {
            HasA[] xs = { new HasA(1), new HasA(2), new HasA(3) };

            var result1 = R.Find(R.PropEq<HasA, int>("A", 2))(xs);
            var expected1 = new HasA(2);

            var result2 = R.Find(R.PropEq<HasA, int>("A", 4))(xs);

            Assert.IsTrue(result1.CompareTo(expected1) == 0);
            Assert.AreEqual(result2, null);
        }
    }
}