using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
  [TestClass]
  public class RamdatNet_AdjustShould
  {

    [TestMethod]
    public void Adjust_At4_Mod3()
    {
      int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      var result = R.Adjust(4, x => x % 3, list);

      var t = R.Curry<int, int, int, int, int>((a, b, c, d) => 1);

      CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 2, 6, 7, 8, 9 }, result);
    }
  }
}