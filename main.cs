using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter wind speed in mph: ");

    double windMph;
    bool isMphValid = double.TryParse(Console.ReadLine(), out windMph);

    if (isMphValid)
    {
      Console.WriteLine("Incorrect input. Enter a valid number");
      return;
      }
    if (windMph >= 157)
    {
      Console.WriteLine("Category Five Hurricane");
    }
    if (windMph >= 130)
    {
      Console.WriteLine("Category Four Hurricane");
    }
    if (windMph >= 111)
    {
      Console.WriteLine("Category Three Hurricane");
    }
    if (windMph >= 96)
    {
      Console.WriteLine("Category Two Hurricane");
    }
    if (windMph >= 74)
    {
      Console.WriteLine("Category One Hurricane");
    }
    else if (windMph < 74)
    {
      Console.WriteLine("Not a hurricane");
    }
  }
}
//20240920_RobertsonXiomar_3.2