using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
  [TestClass]
  public class AllTests
  {
    [TestMethod]
    public void All_AreEven()
    {
      int[] a = { 2, 4, 6, 8, 10 };
      int[] b = { 2, 4, 6, 8, 9 };
      int[] c = { 2, 4, 6, 7, 9 };

      Assert.IsTrue(R.All<int>(x => x % 2 == 0)(a));
      Assert.IsFalse(R.All<int>(x => x % 2 == 0)(b));
      Assert.IsFalse(R.All<int>(x => x % 2 == 0)(c));
    }
    [TestMethod]
    public void All_EmptyList()
    {
      int[] a = { };

      Assert.IsTrue(R.All<int>(x => x % 2 == 0)(a));
      Assert.IsTrue(R.All<int>(x => x % 2 == 1)(a));
    }
  }
}