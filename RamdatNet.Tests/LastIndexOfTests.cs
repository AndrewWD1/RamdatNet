using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class LastIndexOfTests
    {
        [TestMethod]
        public void LastIndexOfTests_Docs()
        {
            Assert.AreEqual(
                R.LastIndexOf(3)(new int[] { -1, 3, 3, 0, 1, 2, 3, 4 }),
                6
            );

            Assert.AreEqual(
                R.LastIndexOf(10)(new int[] { 1, 2, 3, 4 }),
                -1
            );
        }
    }
}