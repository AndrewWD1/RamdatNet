using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
  [TestClass]
  public class AdjustTests
  {

    [TestMethod]
    public void Adjust_Empty_List()
    {
      int[] list = { };
      var result = R.Adjust(4, x => x % 3, list);

      CollectionAssert.AreEqual(new int[] { }, result);
    }

    [TestMethod]
    public void Adjust_At4_Mod3()
    {
      int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      var result = R.Adjust(4, x => x % 3, list);

      CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 2, 6, 7, 8, 9 }, result);
    }

    [TestMethod]
    public void Adjust_At0_Square()
    {
      int[] list = { 1, 2, 3, 4, 5, 6, 7, 8 };
      var result = R.Adjust(3, x => x * x, list);

      CollectionAssert.AreEqual(new int[] { 1, 2, 3, 16, 5, 6, 7, 8 }, result);
    }
  }
}