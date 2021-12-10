using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetQty_ReturnPastryQty_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1, newPastry.PastryQty);
    }

    [TestMethod]
    public void GetCost_ReturnPastryCostSinglePastry_Int()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(2, newPastry.PastryCost);
    }

    [TestMethod]
    public void GetPastry_ReturnBreadQtyAndCostSinglePastry_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1, newPastry.PastryQty);
      Assert.AreEqual(2, newPastry.PastryCost);
    }

    [TestMethod]
    public void GetPastryTotal_ReturnCostOfTwoPastries_Int()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(4, newPastry.GetPrice());
    }

    [TestMethod]
    public void GetPastryTotal_ReturnCostOfThreePastries_Int()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(5, newPastry.GetPrice());
    }

    [TestMethod]
    public void GetPastryTotal_ReturnCostOfSixPastries_Int()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(10, newPastry.GetPrice());
    }
  }
}