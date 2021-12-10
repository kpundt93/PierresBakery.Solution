namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost {get; set;}
    public int BreadQty {get; set;}

    public Bread(int breadQty)
    {
      BreadQty = breadQty;
    }
  }
}