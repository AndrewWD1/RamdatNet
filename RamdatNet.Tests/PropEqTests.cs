using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class PropEqTests
    {
        [TestMethod]
        public void PropEqTests_Docs()
        {
            Assert.IsTrue(R.PropEq("A", 5)(new { A = 5 }));

            Assert.IsFalse(R.PropEq("A", 5)(new { B = 5 }));
        }
    }
}