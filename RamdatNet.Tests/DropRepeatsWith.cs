using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DropRepeatsWith
    {
        [TestMethod]
        public void DropRepeatsWith_Tests_Docs()
        {
            int[] l = { 1, -1, 1, 3, 4, -4, -4, -5, 5, 3, 3 };
            var result = R.DropRepeatsWith<int>((x, y) => Math.Abs(x) == Math.Abs(y))(l);
            int[] expected = { 1, 3, 4, -5, 3 };

            CollectionAssert.AreEqual(expected, result.ToArray());
        }
        [TestMethod]
        public void DropRepeatsWith_Tests_String()
        {
            string a = "rraammddaa";
            var result = R.DropRepeatsWith((x, y) => $"{x}{y}" == "rr")(a);
            var expected = "raammddaa";

            Assert.AreEqual(expected, result);
        }
    }
}