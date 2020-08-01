using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class TailTests
    {
        [TestMethod]
        public void TailTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Tail(new int[] { 1, 2, 3 }).ToArray(), new int[] { 2, 3 }
            );
            CollectionAssert.AreEqual(
                R.Tail(new int[] { 1, 2 }).ToArray(), new int[] { 2 }
            );
            CollectionAssert.AreEqual(
            R.Tail(new int[] { 1 }).ToArray(), new int[] { }
            );
            CollectionAssert.AreEqual(
            R.Tail(new int[] { }).ToArray(), new int[] { }
            );
            Assert.AreEqual(R.Tail("abc"), "bc");
            Assert.AreEqual(R.Tail("ab"), "b");
            Assert.AreEqual(R.Tail("a"), "");
            Assert.AreEqual(R.Tail(""), "");
        }
    }
}