using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ReverseTests
    {
        [TestMethod]
        public void ReverseTests_Docs_Array()
        {
            CollectionAssert.AreEqual(
                R.Reverse(new int[] { 1, 2, 3 }).ToArray(),
                new int[] { 3, 2, 1 }
            );
        }

        [TestMethod]
        public void ReverseTests_Docs_String()
        {
            Assert.AreEqual(
                R.Reverse("abc"),
                "cba"
            );
        }
    }
}