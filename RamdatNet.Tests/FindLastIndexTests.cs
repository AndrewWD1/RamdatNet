using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet.Tests.TestDoubles;

namespace RamdatNet.Tests
{
    [TestClass]
    public class FindLastIndexTests
    {
        [TestMethod]
        public void FindLastIndexTests_Docs()
        {
            HasAB[] xs = { new HasAB(1, 0), new HasAB(1, 1) };

            var result1 = R.FindLastIndex((HasAB x) => x.A == 1)(xs);
            var result2 = R.FindLastIndex((HasAB x) => x.A == 4)(xs);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(-1, result2);
        }
    }
}