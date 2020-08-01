using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class InsertAllTests
    {
        [TestMethod]
        public void InsertAllTests_Docs()
        {
            var t = R.InsertAll(2, new int[] { 7, 8, 9 }, new int[] { 1, 2, 3, 4 });

            CollectionAssert.AreEqual(t.ToArray(), new int[] { 1, 2, 7, 8, 9, 3, 4 });
        }
    }
}