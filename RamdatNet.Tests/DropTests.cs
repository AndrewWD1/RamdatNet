using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DropTests
    {
        [TestMethod]
        public void DropTests_Docs_Enumerables()
        {
            var result1 = R.Drop<string>(1)(new string[] { "foo", "bar", "baz" });
            var expected1 = new string[] { "bar", "baz" };

            var result2 = R.Drop<string>(2)(new string[] { "foo", "bar", "baz" });
            var expected2 = new string[] { "baz" };

            var result3 = R.Drop<string>(4)(new string[] { "foo", "bar", "baz" });
            var expected3 = new string[] { };

            CollectionAssert.AreEqual(result1.ToArray(), expected1);
            CollectionAssert.AreEqual(result2.ToArray(), expected2);
            CollectionAssert.AreEqual(result3.ToArray(), expected3);
        }

        [TestMethod]
        public void DropTests_Docs_String()
        {
            var result4 = R.Drop(3)("ramda");
            var expected4 = "da";

            Assert.AreEqual(result4, expected4);
        }
    }
}