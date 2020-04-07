using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class FlipTests
    {
        [TestMethod]
        public void FlipTests_Docs()
        {
            int[] mergeThree(params int[] args)
            {
                return args;
            }

            var result = R.Flip<int, int[]>(mergeThree)(1, 2, 3);

            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, result);
        }

        [TestMethod]
        public void FlipTests_Func()
        {
            Func<int, int, int, int[]> mergeThree = (x, y, z) => new int[] { x, y, z };

            var result = R.Flip(mergeThree)(1)(2)(3);

            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, result);
        }
    }
}