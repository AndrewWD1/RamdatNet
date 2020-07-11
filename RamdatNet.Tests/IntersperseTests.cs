using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class IntersperseTests
    {
        [TestMethod]
        public void IntersperseTests_Docs()
        {
            var t = R.Intersperse('a')(new char[] { 'b', 'n', 'n', 's' });

            CollectionAssert.AreEqual(t.ToArray(), new char[] { 'b', 'a', 'n', 'a', 'n', 'a', 's' });
        }
    }
}