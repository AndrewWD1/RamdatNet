using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void MapTests_Docs()
        {
            var result = R.Map((int x) => x * 2)(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 2, 4, 6 });
        }
    }
}