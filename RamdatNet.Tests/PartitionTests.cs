using Microsoft.VisualStudio.TestTools.UnitTesting;

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