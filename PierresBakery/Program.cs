using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("- - - - - - - - - - - - - - - -");
      Console.WriteLine(" Welcome to Pierre's Bakery!");
      Console.WriteLine("- - - - - - - - - - - - - - - -");
      Console.WriteLine("Our prices:");
      Console.WriteLine("Bread: $5/ea");
      Console.WriteLine("Pastries: $2/ea");
      Console.WriteLine();
      Console.WriteLine("Current deals:");
      Console.WriteLine("Bread: Buy 2, get 1 free!");
      Console.WriteLine("Pastries: Buy 3 for $5!");
      Console.WriteLine("- - - - - - - - - - - - - - -");
      Console.WriteLine("Would you like to place an order? \n(Enter 'Y' for yes, enter any other key to exit)");
      string newOrder = Console.ReadLine();

      if (newOrder == "y" || newOrder == "Y")
      {
        Console.WriteLine("- - - - - - - - - - - - - - -");
        Console.WriteLine("- - - - - New order - - - - -");
        Console.WriteLine("- - - - - - - - - - - - - - -");
        Console.WriteLine("How many loaves of bread would you like to order?");
        string breadQtyStr = Console.ReadLine();
        int breadQty = int.Parse(breadQtyStr);
        Bread newBread = new Bread(breadQty);
        int breadTotal = newBread.GetPrice();
        Console.WriteLine("Bread Total: $" + breadTotal);
        Console.WriteLine("- - - - - - - - - - - - - - -");
        Console.WriteLine("How many pastries would you like to order?");
        string pastryQtyStr = Console.ReadLine();
        int pastryQty = int.Parse(pastryQtyStr);
        Pastry newPastry = new Pastry(pastryQty);
        int pastryTotal = newPastry.GetPrice();
        Console.WriteLine("Pastry Total: $" + pastryTotal);
        Console.WriteLine("- - - - - - - - - - - - - - -");
        int grandTotal = breadTotal + pastryTotal;
        Console.WriteLine("Order total: $" + grandTotal);
      }
      else 
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}