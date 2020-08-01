using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RamdatNet.Tests
{
    [TestClass]
    public class CurryTests
    {
        [TestMethod]
        public void CurryTests_Docs_2args()
        {
            Func<int, int, int> Add = R.Add;

            Assert.AreEqual(R.Curry(Add)(1)(5), 1 + 5);
        }
    }
}