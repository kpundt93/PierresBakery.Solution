namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryCost {get; set;}
    public int PastryQty {get; set;}

    public Pastry(int pastryQty)
    {
      PastryQty = pastryQty;
    }
  }
}