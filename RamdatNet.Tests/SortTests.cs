using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void SortTests_Docs()
        {
            static int diff(int a, int b) => a - b;

            CollectionAssert.AreEqual(
                R.Sort(diff, new int[] { 4, 2, 7, 5 }).ToArray(),
                new int[] { 2, 4, 5, 7 }
            );
        }
    }
}