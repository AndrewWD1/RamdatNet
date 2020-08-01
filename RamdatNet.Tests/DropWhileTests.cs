using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DropWhileTests
    {
        [TestMethod]
        public void DropWhileTests_Docs_Enumerables()
        {
            Predicate<int> LteTwo = x => 2 >= x;
            var result = R.DropWhile(LteTwo)(new int[] { 1, 2, 3, 4, 3, 2, 1 });
            var expected = new int[] { 3, 4, 3, 2, 1 };

            CollectionAssert.AreEqual(expected, result.ToArray());
        }

        [TestMethod]
        public void DropWhileTests_Docs_Strings()
        {
            var result = R.DropWhile(x => x != 'd')("Ramda");
            var expected = "da";

            Assert.AreEqual(expected, result);
        }
    }
}