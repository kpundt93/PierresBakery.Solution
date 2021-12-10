using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetQty_ReturnBreadQty_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(1, newBread.BreadQty);
    }

    [TestMethod]
    public void GetCost_ReturnBreadCostSingleLoaf_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(5, newBread.BreadCost);
    }

    [TestMethod]
    public void GetBread_ReturnBreadQtyAndCostSingleLoaf_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(1, newBread.BreadQty);
      Assert.AreEqual(5, newBread.BreadCost);
    }

    [TestMethod]
    public void GetBread_ReturnCostOfTwoLoaves_Int()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(10, newBread.GetPrice());
    }

    [TestMethod]
    public void GetBread_ReturnCostOfThreeLoaves_Int()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, newBread.GetPrice());
    }
  }
}