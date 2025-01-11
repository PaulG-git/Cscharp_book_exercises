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

      } while (InputMethods.AskToContinue("Do you want to define a new cylinder?"));
    }

    private static void ShowResults(int radius, int height)
    {
      Console.WriteLine($"\nThe cylinder has an radius of {radius} cm and height of {height} cm.");
      Console.WriteLine($"The surface area of the cylinder is {(double)CylinderCalculationMethods.CalculateSurfaceArea(radius, height)} cm².");
      Console.WriteLine($"The volume of the cylinder is {(double)CylinderCalculationMethods.CalculateVolume(radius, height)} cm³.");
    }
  }
}