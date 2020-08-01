using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class TakeWhileTests
    {
        [TestMethod]
        public void TakeWhileTests_Docs()
        {
            static bool isNotFour(int x) => x != 4;
            CollectionAssert.AreEqual(
                R.TakeWhile<int>(isNotFour)(new int[] { 1, 2, 3, 4, 3, 2, 1 }).ToArray(),
                new int[] { 1, 2, 3 }
            );

            Assert.AreEqual(R.TakeWhile(x => x != 'd')("Ramda"), "Ram");
        }
    }
}