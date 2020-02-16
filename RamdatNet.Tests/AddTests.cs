using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
  [TestClass]
  public class AddTests
  {
    [TestMethod]
    public void Add_InputIs1_InputIs2_Return3()
    {
      var result = R.Add(1)(2);

      Assert.AreEqual(3, result);
    }
  }
}