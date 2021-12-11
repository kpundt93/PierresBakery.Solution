using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("- - - - - - - - - - - - - - -");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("- - - - - - - - - - - - - - -");
      Console.WriteLine("Our prices:");
      Console.WriteLine("Bread: $5/ea");
      Console.WriteLine("Pastries: $2/ea");
      Console.WriteLine();
      Console.WriteLine("Current deals:");
      Console.WriteLine("Bread: Buy 2, get 1 free!");
      Console.WriteLine("Pastries: Buy 3 for $5!");
      Console.WriteLine("- - - - - - - - - - - - - - -");
      Console.WriteLine("Would you like to place an order (Enter Y for yes, enter any other key to exit)?");
      string newOrder = Console.ReadLine();

      if (newOrder == "y" || newOrder == "Y")
      {
        Console.WriteLine("Start order!");
      }
      else 
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}