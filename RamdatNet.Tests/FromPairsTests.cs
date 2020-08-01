using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class FromPairsTests
    {
        [TestMethod]
        public void FromPairsTests_Docs()
        {
            var result = R.FromPairs(new (char, int)[] { ('a', 1), ('b', 2), ('c', 3), ('c', 4) });

            Assert.AreEqual(result.Count(), 3);
            Assert.AreEqual(result['a'], 1);
            Assert.AreEqual(result['b'], 2);
            Assert.AreEqual(result['c'], 4);
        }
    }
}