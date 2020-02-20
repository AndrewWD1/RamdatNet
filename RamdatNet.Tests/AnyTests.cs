using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AnyTests
    {
        [TestMethod]
        public void AnyTests_Curried_Doc_Code()
        {
            int[] list = { 2, 3, 5 };
            bool a = R.Any((int x) => x % 2 == 0)(list); //-> true 
            bool b = R.Any((int x) => x > 6)(list); //-> false

            Assert.IsTrue(a);
            Assert.IsFalse(b);
        }

        [TestMethod]
        public void AnyTests_Doc_Code()
        {
            int[] list = { 2, 3, 5 };
            bool a = R.Any(x => x % 2 == 0, list); //-> true 
            bool b = R.Any(x => x > 6, list); //-> false

            Assert.IsTrue(a);
            Assert.IsFalse(b);
        }
    }
}