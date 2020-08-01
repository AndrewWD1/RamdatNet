using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet.Tests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class PropTests
    {
        [TestMethod]
        public void PropTests_Docs()
        {
            Assert.AreEqual(
                R.Prop("x")(new { x = 100 }),
                100
            );

            Assert.IsNull(R.Prop("x")(new { y = 100 }));
        }

        [TestMethod]
        public void PropTests_Docs_Typed()
        {
            HasAB obj = new HasAB(1, 9);

            Assert.AreEqual(
                R.Prop<int>("A")(obj),
                1
            );

            Assert.AreEqual(
                R.Prop<int>("B")(obj),
                9
            );

            Assert.AreEqual(R.Prop<int>("C")(obj), default);
        }
    }
}