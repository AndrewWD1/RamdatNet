using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    class HasB
    {
        public int B { get; set; }
        public HasB(int b)
        {
            B = b;
        }
    }
    [TestClass]
    public class FindIndexTests
    {
        [TestMethod]
        public void FindIndexTests_Docs()
        {
            HasB[] list = { new HasB(1), new HasB(3) };
            var result = R.FindIndex((HasB x) => x.B == 5)(list);
            var expected = 3;

            Assert.AreEqual(expected, result);
        }

    }
}