using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet;

namespace RamdatNet.Tests
{
  [TestClass]
  public class AllPassTests
  {
    Predicate<int> checker
      = R.AllPass(new Predicate<int>[] {
        x => x % 7 == 0,
        x => x > 10,
        x => x < 20
      });

    [TestMethod]
    public void AllPass()
    {
      Assert.IsTrue(checker(14));
      Assert.IsFalse(checker(13));
      Assert.IsFalse(checker(21));
      Assert.IsFalse(checker(7));
    }
  }
}