using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class PartitionTests
    {
        [TestMethod]
        public void PartitionTests_Docs()
        {
            R.Partition(R.Includes("s"))(new string[] { "sss", "ttt", "foo", "bars" });
            // => { { "sss", "bars" },  { "ttt", "foo" } }
        }
    }
}