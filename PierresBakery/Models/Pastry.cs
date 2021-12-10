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
      pastryTotal = PastryQty * PastryCost;
      return pastryTotal;
    }
  }
}