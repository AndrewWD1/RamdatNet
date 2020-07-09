using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class InitTests
    {
        [TestMethod]
        public void InitTests_Docs()
        {
            var v1 = new int[] { 1, 2, 3 };
            var v2 = new int[] { 1, 2 };
            var v3 = new int[] { 1 };
            var v4 = new int[] { };

            CollectionAssert.AreEqual(R.Init(v1).ToArray(), v2);
            CollectionAssert.AreEqual(R.Init(v2).ToArray(), v3);
            CollectionAssert.AreEqual(R.Init(v3).ToArray(), v4);
            CollectionAssert.AreEqual(R.Init(v4).ToArray(), v4);

            Assert.AreEqual(R.Init("abc"), "ab");
            Assert.AreEqual(R.Init("ab"), "a");
            Assert.AreEqual(R.Init("a"), "");
            Assert.AreEqual(R.Init(""), "");
        }
    }
}