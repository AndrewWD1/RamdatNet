using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ApertureTests
    {
        [TestMethod]
        public void ApertureTests_ints_2()
        {
            var result = R.Aperture<int>(2)(new int[] { 1, 2, 3, 4, 5 }).ToList();

            List<List<int>> expected = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 5 } };

            /**
            *   * Have to use a loop since CollectionAssert.AreEqual only tests equality one-level deep.
            */
            for (int i = 0; i < expected.Count(); i++)
            {
                CollectionAssert.AreEqual(result[i].ToArray(), expected[i]);
            }
        }

        [TestMethod]
        public void ApertureTests_ints_3()
        {
            var result = R.Aperture<int>(3)(new int[] { 1, 2, 3, 4, 5 }).ToList();

            List<int[]> expected = new List<int[]> { new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 }, new int[] { 3, 4, 5 } };

            /**
            *   * Have to use a loop since CollectionAssert.AreEqual only tests equality on-level deep.
            */
            for (int i = 0; i < expected.Count(); i++)
            {
                CollectionAssert.AreEqual(result[i].ToArray(), expected[i]);
            }
        }

        [TestMethod]
        public void ApertureTests_ints_over()
        {
            var result = R.Aperture<int>(7)(new int[] { 1, 2, 3, 4, 5 });
            CollectionAssert.AreEqual(new int[][] { }, result.ToArray());
        }
    }
}