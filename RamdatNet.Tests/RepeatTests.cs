using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RamdatNet.Tests
{
    [TestClass]
    public class RepeatTests
    {
        [TestMethod]
        public void RepeatTests_Docs()
        {
            CollectionAssert.AreEqual(
                R.Repeat("hi", 5).ToArray(),
                new string[] { "hi", "hi", "hi", "hi", "hi", }
            );
        }
    }
}