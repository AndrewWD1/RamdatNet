using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class PathTests
    {
        [TestMethod]
        public void PathTests_Docs()
        {
            Assert.AreEqual(
                R.Path(new string[] { "a", "b" })(new { a = new { b = 2 } }),
                2
            );
        }
    }
}