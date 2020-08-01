using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AppendTests
    {
        [TestMethod]
        public void AppendTests_Docs()
        {
            var result = R.Append("tests")(new string[] { "write", "more" });
            //=> { "write", "more", "tests" }
            CollectionAssert.AreEqual(new string[] { "write", "more", "tests" }, result.ToArray());
        }
    }
}