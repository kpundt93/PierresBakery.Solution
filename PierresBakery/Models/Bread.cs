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
      int breadTotal = BreadQty * BreadCost;
      return breadTotal;
    }
  }
}