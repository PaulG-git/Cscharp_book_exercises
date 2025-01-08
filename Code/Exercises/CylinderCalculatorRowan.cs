using static Exercises.UiMethods.ConsoleUIMethods;

namespace CylinderCalculator
{
  internal class CylinderCalculatorRowan
  {
    public static void CalculatorRowanMain()
    {
      do
      {
        int radius = GetPositiveInt("Define the radius of the cylinder in cm: ");
        int height = GetPositiveInt("Define the height of the cylinder in cm: ");

        double volume = CalculateVolume(radius, height);
        double surfaceArea = CalculateSurfaceArea(radius, height);

        DisplayResults(radius, height, volume, surfaceArea);

      }
      while (AskToContinue());
    }

    private static int GetPositiveInt(string prompt)
    {
      Console.WriteLine(prompt);
      while (true)
      {
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int value) && value > 0)
        {
          return value;
        }
        else 
        {
          Console.Clear();
          Console.WriteLine(prompt);
          Console.WriteLine("Please enter a valid positive integer.");
          Console.SetCursorPosition(0, Console.CursorTop);
        }
      }
    }

    private static double CalculateVolume(int radius, int height)
    {
      return Math.PI * Math.Pow(radius, 2) * height;
    }

    private static double CalculateSurfaceArea(int radius, int height)
    {
      return 2 * Math.PI * radius * (radius + height);
    }

    private static void DisplayResults(int radius, int height, double volume, double surfaceArea)
    {
      Console.WriteLine($"The cylinder has a radius of {radius} cm and a height of {height} cm.");
      Console.WriteLine($"The surface area of the cylinder is {surfaceArea} cm².");
      Console.WriteLine($"The volume of the cylinder is {volume} cm³.");
    }

    private static bool AskToContinue()
    {
      while (true)
      {
        Console.WriteLine("Do you want to define a new cylinder? Type 'y' for 'yes' or 'n' for 'no' and press Enter.");
        char input = Console.ReadKey().KeyChar;

        if (input == 'y')
        {
          Console.Clear();
          return true;
        }
        else if (input == 'n')
        {
          return false;
        }
        ClearCurrentConsoleLine();
        Console.WriteLine("You entered the wrong answer! Please answer with 'y' for 'yes' or 'n' for 'no'.");
      }
    }
  }
}