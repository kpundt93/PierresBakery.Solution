namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost {get; set;}
    public int BreadQty {get; set;}

    public Bread(int breadQty)
    {
      BreadQty = breadQty;
      BreadCost = 5;
    }

    public int GetPrice()
    {
      int breadTotal;
      int breadDiscount = (BreadQty - (BreadQty % 3)) / 3  * BreadCost;

      if (BreadQty >= 3)
      {
        breadTotal = (BreadQty * BreadCost) - breadDiscount;
        return breadTotal;
      }
      else
      {
        breadTotal = BreadQty * BreadCost;
        return breadTotal;
      }
    }
  }
}