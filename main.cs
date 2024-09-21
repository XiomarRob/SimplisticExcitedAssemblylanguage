using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter wind speed in mph:");

    double windInMph;
    bool isMphValid = double.TryParse(Console.ReadLine(), out windInMph);

    if (!isMphValid)
    {
      Console.WriteLine("Incorrect input. Enter a valid number");
      return;
      }
    if (windInMph >= 157)
    {
      Console.WriteLine("Category Five Hurricane");
    }
    else if (windInMph >= 130)
    {
      Console.WriteLine("Category Four Hurricane");
    }
    else if (windInMph >= 111)
    {
      Console.WriteLine("Category Three Hurricane");
    }
    else if (windInMph >= 96)
    {
      Console.WriteLine("Category Two Hurricane");
    }
    else if (windInMph >= 74)
    {
      Console.WriteLine("Category One Hurricane");
    }
    else
    {
      Console.WriteLine("Not a hurricane");
    }
  }
}
//20240920_RobertsonXiomar_3.2