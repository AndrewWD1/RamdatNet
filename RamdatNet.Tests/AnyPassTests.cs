using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AnyPassTests
    {
        static Predicate<int> Checker = R.AnyPass(new Predicate<int>[] {
            x => x % 2 == 0,
            x => x > 1
        });

        [TestMethod]
        public void AnyPass_Checker()
        {
            var result0 = Checker(0);
            var result1 = Checker(1);
            Assert.IsTrue(result0);
            Assert.IsFalse(result1);
        }

        [TestMethod]
        public void AnyPass_Empty_Predicate_List()
        {
            Predicate<int> EmptyChecker = R.AnyPass(new Predicate<int>[] { });

            var result = EmptyChecker(1);
            Assert.IsFalse(result);
        }
    }
}