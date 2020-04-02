using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet.Tests.TestDoubles;

namespace RamdatNet.Tests
{
    [TestClass]
    public class FindIndexTests
    {
        [TestMethod]
        public void FindIndexTests_Docs()
        {
            HasB[] list = { new HasB(1), new HasB(3) };
            var result = R.FindIndex((HasB x) => x.B == 3)(list);
            var expected = 1;

            Assert.AreEqual(expected, result);
        }
    }
}