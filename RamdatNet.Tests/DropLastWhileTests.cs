using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DropLastWhileTests
    {
        [TestMethod]
        public void DropLastWhileTests_Docs_Enumerable()
        {
            Predicate<int> lteThree = x => 3 >= x;
            var result = R.DropLastWhile(lteThree)(new int[] { 1, 2, 3, 4, 3, 2, 1 });
            int[] expected = { 1, 2, 3, 4 };

            CollectionAssert.AreEqual(expected, result.ToArray());
        }

        [TestMethod]
        public void DropLastWhileTests_Docs_String()
        {
            var result = R.DropLastWhile(x => x != 'd')("Ramda");
            var expected = "Ramd";

            Assert.AreEqual(expected, result);
        }
    }
}