using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ApplyToTests
    {
        [TestMethod]
        public void ApplyTo_Docs()
        {
            var t42 = R.ApplyTo<int, int>(42);
            var result = t42(R.Add(1));
            var expected = 43;

            Assert.AreEqual(expected, result);
        }
    }
}