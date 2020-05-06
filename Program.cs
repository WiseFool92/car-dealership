using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "It's clobberin' time!", "includes passenger ejection button!");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "like driving a deviled egg.", "This puppy packs a .50cal 'parking space deepener'.");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Built Ford tough.", "Dual flamethrowers for when you want to heat it up");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "ace of pace.", "Includes oil slick");

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      yugo.SetPrice(300);

      Console.Write("Enter maximum budget price:");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.Write("Enter your desired mileage:");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach (Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(Car.MakeSound("bang"));
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine("Note from seller: " + automobile.GetNote());
        Console.WriteLine(automobile.GetGadget());
      }
    }
  }
}