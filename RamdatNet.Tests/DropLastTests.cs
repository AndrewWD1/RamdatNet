using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DropLastTests
    {
        [TestMethod]
        public void DropLastTests_Docs_Enumerables()
        {
            var result1 = R.DropLast<string>(1)(new string[] { "foo", "bar", "baz" });
            var expected1 = new string[] { "foo", "bar" };

            var result2 = R.DropLast<string>(2)(new string[] { "foo", "bar", "baz" });
            var expected2 = new string[] { "foo" };

            var result3 = R.DropLast<string>(4)(new string[] { "foo", "bar", "baz" });
            var expected3 = new string[] { };

            CollectionAssert.AreEqual(result1.ToArray(), expected1);
            CollectionAssert.AreEqual(result2.ToArray(), expected2);
            CollectionAssert.AreEqual(result3.ToArray(), expected3);
        }

        [TestMethod]
        public void DropTests_Docs_String()
        {
            var result4 = R.DropLast(3)("ramda");
            var expected4 = "ra";

            Assert.AreEqual(result4, expected4);
        }

    }
}