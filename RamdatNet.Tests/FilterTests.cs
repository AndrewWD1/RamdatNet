using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void FilterTests_Docs()
        {
            var result = R.Filter((int x) => x % 2 == 0)(new int[] { 1, 2, 3, 4 });
            int[] expected = { 2, 4 };

            CollectionAssert.AreEqual(expected, result.ToArray());
        }
    }
}