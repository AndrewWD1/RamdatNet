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
    }
}