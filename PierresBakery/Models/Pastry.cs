namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryCost {get; set;}
    public int PastryQty {get; set;}

    public Pastry(int pastryQty)
    {
      PastryQty = pastryQty;
      PastryCost = 2;
    }

    public int GetPrice()
    {
      int pastryTotal;
      int pastryDiscount = (PastryQty - (PastryQty % 3)) / 3;

      if (PastryQty >= 3)
      {
        pastryTotal = (PastryQty * PastryCost) - pastryDiscount;
        return pastryTotal;
      }
      else
      {
        pastryTotal = PastryQty * PastryCost;
        return pastryTotal;
      }
    }
  }
}