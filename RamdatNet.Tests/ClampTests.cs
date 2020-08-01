using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ClampTests
    {
        [TestMethod]
        public void ClampTests_Docs()
        {
            Assert.AreEqual(1, R.Clamp(1, 10)(-5));
            Assert.AreEqual(10, R.Clamp(1, 10)(15));
            Assert.AreEqual(4, R.Clamp(1, 10)(4));
        }
    }
}