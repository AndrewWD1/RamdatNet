using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RamdatNet.Tests
{
    [TestClass]
    public class AllPassTests
    {
        private readonly Predicate<int> Checker = R.AllPass(
            new Predicate<int>[]
            {
                x => x % 7 == 0,
                x => x > 10,
                x => x < 20
            }
        );

        [TestMethod]
        public void AllPass_Checker()
        {
            Assert.IsTrue(Checker(14));
            Assert.IsFalse(Checker(13));
            Assert.IsFalse(Checker(21));
            Assert.IsFalse(Checker(7));
        }

        [TestMethod]
        public void AllPass_Empty_Predicate_List()
        {
            Assert.IsTrue(
                R.AllPass(new Predicate<int>[] { })(10)
            );
        }
    }
}