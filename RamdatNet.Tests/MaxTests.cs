using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class MaxTests
    {
        [TestMethod]
        public void MaxTests_Docs()
        {
            Assert.AreEqual(
                R.Max(789)(123),
                789
            );

            Assert.AreEqual(
                R.Max('a')('b'),
                'b'
            );
        }
    }
}