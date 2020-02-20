using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AndTests
    {
        [TestMethod]
        public void AndTests_tests()
        {
            Assert.IsTrue(R.And(true, true));
            Assert.IsFalse(R.And(true, false));
            Assert.IsFalse(R.And(false, true));
            Assert.IsFalse(R.And(false, false));
        }
    }
}