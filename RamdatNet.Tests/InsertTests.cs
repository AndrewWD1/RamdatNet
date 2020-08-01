using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class InsertTests
    {
        [TestMethod]
        public void InsertTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Insert(2, 9, new int[] { 1, 2, 3, 4 }).ToArray(),
                new int[] { 1, 2, 9, 3, 4 }
            );
        }
    }
}