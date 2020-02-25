using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class DropRepeats
    {
        [TestMethod]
        public void DropRepeats_Docs_Enumerable()
        {
            var result = R.DropRepeats(new int[] { 1, 1, 1, 2, 3, 4, 4, 2, 2 });
            int[] expected = { 1, 2, 3, 4, 2 };

            CollectionAssert.AreEqual(expected, result.ToArray());
        }

        [TestMethod]
        public void DropRepeats_Docs_String()
        {
            var result = R.DropRepeats("rraammddaa");
            var expected = "ramda";

            Assert.AreEqual(expected, result);
        }

    }
}