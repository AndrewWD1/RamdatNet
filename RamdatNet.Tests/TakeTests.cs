﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class TakeTests
    {
        [TestMethod]
        public void TakeTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Take<int>(3)(new int[] { 1, 2, 3, 4, 5 }).ToArray(),
                new int[] { 1, 2, 3 }
            );
        }
    }
}