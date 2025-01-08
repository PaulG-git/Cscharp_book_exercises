using Exercises.UiMethods;
using Exercises.CalculationMethods;

namespace CylinderCalculator
{
  internal class CylinderCalculatorPaul
  {
    public static void CalculatorPaulMain()
    {
      do
      {
        int radius = NumberInputMethods.GetInputPositiveInt("Define the radius of the cylinder in cm: ");
        int height = NumberInputMethods.GetInputPositiveInt("Define the height of the cylinder in cm: ");

        ShowResults(radius, height);

      } while (AskToContinue());
    }

    private static void ShowResults(int radius, int height)
    {
      Console.WriteLine($"\nThe cylinder has an radius of {radius} cm and height of {height} cm.");
      Console.WriteLine($"The surface area of the cylinder is {(double)CylinderCalculationMethods.CalculateSurfaceArea(radius, height)} cm².");
      Console.WriteLine($"The volume of the cylinder is {(double)CylinderCalculationMethods.CalculateVolume(radius, height)} cm³.");
    }

    private static bool AskToContinue()
    {
      Console.WriteLine("\nDo you want to define a new cylinder? Type 'y' for 'yes' or 'n' for 'no'. To go back to main menu, please press 'r'.");
      
      bool looped = false;      
      while ( true ) 
      {
        char userAnswer = Console.ReadKey().KeyChar;
        if (userAnswer == 'y')
        {
          Console.Clear();
          return true;
        }
        else if (userAnswer == 'n')
        {
          return false;
        }
        else if (userAnswer == 'r') 
        {
          Console.Clear();
          Exercises.MainProgram.Main();
        }

        if (looped)
        {
          ConsoleUIMethods.ClearLastXLines(2);
        }
        else
        {
          ConsoleUIMethods.ClearLastTwoLines();
        }
        looped = WrongAnswer();
      }
    }

    private static bool WrongAnswer()
    {
      Console.WriteLine("You entered the wrong answer!");
      Console.WriteLine("Please answer with 'y' for 'yes' or 'n' for 'no'. To return to main menu press 'r'.");
      return true;
    }
  }
}