using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet.Tests.TestDoubles;

namespace RamdatNet.Tests
{
    [TestClass]
    public class HasTests
    {
        [TestMethod]
        public void HasTests_Docs()
        {
            HasAB o = new HasAB(1, 2);
            var result1 = R.Has("A")(o);
            var result2 = R.Has<HasAB>("B")(o);
            var result3 = R.Has("C")(o);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}