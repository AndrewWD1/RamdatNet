using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class IncludesTests
    {
        [TestMethod]
        public void IncludesTests_Docs()
        {
            Assert.IsTrue(R.Includes(3, new int[] { 1, 2, 3 }));
            Assert.IsFalse(R.Includes(4, new int[] { 1, 2, 3 }));

            var arr = new int[] { 42 };

            Assert.IsTrue(R.Includes(arr, new int[][] { arr }));
        }
    }
}