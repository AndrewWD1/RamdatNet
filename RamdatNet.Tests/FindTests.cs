using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    class HasA : IComparable
    {
        public int a { get; set; }
        public HasA(int a)
        {
            this.a = a;
        }

        public int CompareTo(object obj)
        {
            return -1;
        }
        public int CompareTo(HasA obj)
        {
            return this.a.CompareTo(obj.a);
        }
    }

    [TestClass]
    public class FindTests
    {


        [TestMethod]
        public void FindTests_Docs()
        {
            HasA[] xs = { new HasA(a: 1), new HasA(a: 2), new HasA(a: 3) };

            var result1 = R.Find(R.PropEq<HasA, int>("a", 2))(xs);
            var expected1 = new HasA(a: 2);

            var result2 = R.Find(R.PropEq<HasA, int>("a", 4))(xs);

            Assert.IsTrue(result1.CompareTo(expected1) == 0);
            Assert.AreEqual(result2, null);
        }
    }
}