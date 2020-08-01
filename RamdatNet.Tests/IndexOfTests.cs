using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class IndexOfTests
    {
        [TestMethod]
        public void IndexOfTests_Docs()
        {
            var t1 = R.IndexOf(3, new int[] { 1, 2, 3, 4 });
            var t2 = R.IndexOf(10, new int[] { 1, 2, 3, 4 });

            Assert.AreEqual(2, t1);
            Assert.AreEqual(-1, t2);
        }
    }
}