using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void Add_int()
        {
            var result = R.Add(1)(2);

            Assert.AreEqual(1 + 2, result);
        }

        [TestMethod]
        public void Add_double()
        {
            var result = R.Add(1.001)(2.000012);

            Assert.AreEqual(1.001 + 2.000012, result);
        }

        [TestMethod]
        public void Add_decimal()
        {
            var result = R.Add((decimal)1.001)((decimal)2.000012);

            Assert.AreEqual((decimal)1.001 + (decimal)2.000012, result);
        }
    }
}