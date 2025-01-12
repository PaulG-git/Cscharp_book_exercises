using Exercises.UiMethods;
using Exercises.CalculationMethods;

namespace ShapeCalculator
{
  internal class ShapeCalculatorPaul
  {
    /// <summary>
    /// Gets 2 inputs from user and calculates shape parameters.
    /// </summary>
    public static void ShapeCalculatorPaulMain()
    {
      do
      {
        int radius = NumberInputMethods.GetInputPositiveInt("Define the radius of the cylinder in cm: ");
        int height = NumberInputMethods.GetInputPositiveInt("Define the height of the cylinder in cm: ");

        ShowResults(radius, height);

        InputMethods.UserAnswer = InputMethods.AskToContinue("If you want to calculate another cylinder, type 'y'.");
      } while (InputMethods.UserAnswer.Item1);
    }

    /// <summary>
    /// Outputs calculation results to console.
    /// </summary>
    /// <param name="radius"></param>
    /// <param name="height"></param>
    private static void ShowResults(int radius, int height)
    {
      Console.WriteLine($"\nThe cylinder has an radius of {radius} cm and height of {height} cm.");
      Console.WriteLine($"The surface area of the cylinder is {(double)ShapeCalculationMethods.CylinderSurfaceArea(radius, height)} cm².");
      Console.WriteLine($"The volume of the cylinder is {(double)ShapeCalculationMethods.CylinderVolume(radius, height)} cm³.");
    }
  }
}