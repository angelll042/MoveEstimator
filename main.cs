using System;

class Program
{
    public static void Main(string[] args)
    {
        int baseFee = 200;
      double hoursCost = 0.0;
      double milesCost = 0.0;
        Console.Write("Enter number of hours of work: ");
        string inputHours = Console.ReadLine();

        if (double.TryParse(inputHours, out double hoursWorked))
        {
            hoursCost = hoursWorked * 150;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of hours.");
        }
      Console.WriteLine("Enter number of miles: ");
      String inputMiles = Console.ReadLine();
             if (double.TryParse(inputMiles, out double totalMiles))
      {
        milesCost = totalMiles * 2;
        }
      else
      {
           Console.WriteLine("Invalid input. Please enter a valid number of miles.");
        }
  double totalCost = baseFee + hoursCost + milesCost;
    Console.WriteLine($"Total cost: {totalCost}");
    }
      }
  

