using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ConcatTests
    {
        [TestMethod]
        public void ConcatTests_Docs()
        {
            var result1 = R.Concat(new string[] { "ABC", "DEF" });

            Assert.AreEqual("ABCDEF", result1);
        }

    }
}