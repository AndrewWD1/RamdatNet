using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class NthArgTests
    {
        [TestMethod]
        public void NthArgTests_Docs()
        {
            Assert.AreEqual(R.NthArg<char>(1)('a', 'b', 'c'), 'b');
            Assert.AreEqual(R.NthArg<char>(-1)('a', 'b', 'c'), 'c');
        }
    }
}