using Exercises.UiMethods;
using Exercises.CalculationMethods;
using System.Runtime.CompilerServices;

namespace ShapeCalculator
{
  internal class ShapeCalculatorPaul
  {
    /// <summary>
    /// Collection of available shapes to calculate.
    /// </summary>
    private static readonly Dictionary<int, (string, string, Action)> _shapes = new()
    {
      {1, ("(2D) ", nameof(Square), Square)},
      {2, ("(2D) ", nameof(Rectangle), Rectangle)},
      {3, ("(2D) ", nameof(Triangle), Triangle)},
      {4, ("(2D) ", nameof(Circle), Circle)},
      {5, ("(2D) ", nameof(Eclipse), Eclipse)},
      {6, ("(2D) ", nameof(Trapezoid), Trapezoid)},
      {7, ("(3D) ", nameof(Cylinder), Cylinder)},
      {0, ("", "Return to main menu", ProgramMethods.ExitSubProgram)}
    };

    /// <summary>
    /// Prints out supported shapes and asks user to make an choice.
    /// </summary>
    public static void ShapeCalculatorPaulMain()
    {
      do
      {
        Console.WriteLine("Welcome to this basic shapes calculation program.");
        Console.WriteLine("Which shape do you want to calculate?");
        foreach (var action in _shapes)
        {
          if (action.Key == 0)
            Console.WriteLine();
          Console.WriteLine(action.Key + ". " + action.Value.Item1 + action.Value.Item2);
        }

        _shapes[ProgramMethods.CheckInput(_shapes.Count, "Wrong input. Please specify the shape that you want to draw: ")].Item3.Invoke();
      } while (ProgramMethods.UserAnswer.Item2);
    }

    /// <summary>
    /// Asks user to input square dimensions and calculates it's parameters. 
    /// </summary>
    private static void Square()
    { 
      do
      {
        int side = NumberInputMethods.GetInputPositiveInt("Define the sides length of the square in cm: ");
        int perimeter = ShapeCalculationMethods.SquarePerimeter(side);
        int area = ShapeCalculationMethods.SquareArea(side);

        Show2DResults(perimeter, area);
      } while (ProgramMethods.UserAnswer.Item1);
    }

    /// <summary>
    /// Asks user to input rectangle dimensions and calculates it's parameters. 
    /// </summary>
    private static void Rectangle()
    {
      do
      {
        int width = NumberInputMethods.GetInputPositiveInt("Define the width of the rectangle in cm: ");
        int heigth = NumberInputMethods.GetInputPositiveInt("Define the heigth of the rectangle in cm: ");
        int perimeter = ShapeCalculationMethods.RectanglePerimeter(width, heigth);
        int area = ShapeCalculationMethods.RectangleArea(width, heigth);

        Show2DResults(perimeter, area);
      } while (ProgramMethods.UserAnswer.Item1);
    }

    /// <summary>
    /// Asks user to input triangel dimensions and calculates it's parameters. 
    /// </summary>
    private static void Triangle()
    {
      do
      {
        int width = NumberInputMethods.GetInputPositiveInt("Define the base of the triangle in cm: ");
        int heigth = NumberInputMethods.GetInputPositiveInt("Define the heigth of the heigth in cm: ");
        int angle = NumberInputMethods.GetInputPositiveInt("Define angle of the triangle between 1° and 90°. Type in '0' if you only want to calculate the area: ", 90);
        
        double perimeter = ShapeCalculationMethods.TrianglePerimeter(width, heigth, angle);
        double area = ShapeCalculationMethods.TriangleArea(width, heigth, angle);
        Show2DResults(perimeter, area);
        
      } while (ProgramMethods.UserAnswer.Item1);
    }

    /// <summary>
    /// Asks user to input circle radius and calculates it's parameters. 
    /// </summary>
    private static void Circle()
    {
      do
      {
        int radius = NumberInputMethods.GetInputPositiveInt("Define the radius of the circle in cm: ");

        double perimeter = ShapeCalculationMethods.CirclePerimeter(radius);
        double area = ShapeCalculationMethods.CircleArea(radius);
        Show2DResults(perimeter, area);

      } while (ProgramMethods.UserAnswer.Item1);
    }

    /// <summary>
    /// Asks user to input eclipse dimensions and calculates it's parameters. 
    /// </summary>
    private static void Eclipse()
    {

    }

    /// <summary>
    /// Asks user to input trapezoid dimensions and calculates it's parameters. 
    /// </summary>
    private static void Trapezoid()
    {

    }

    /// <summary>
    /// Asks user to input cylinder dimensions and calculates it's parameters. 
    /// </summary>
    private static void Cylinder()
    {
      do
      {
        int radius = NumberInputMethods.GetInputPositiveInt("Define the radius of the cylinder in cm: ");
        int height = NumberInputMethods.GetInputPositiveInt("Define the height of the cylinder in cm: ");
        double surfaceArea = (double)ShapeCalculationMethods.CylinderSurfaceArea(radius, height);
        double volume = (double)ShapeCalculationMethods.CylinderVolume(radius, height);

        ShowResults(surfaceArea, volume);
      } while (ProgramMethods.UserAnswer.Item1);
    }

    /// <summary>
    /// Outputs calculation results of 2D shape to console.
    /// </summary>
    /// <param name="perimeter">Pass the calculated perimeter of the shape.</param>
    /// <param name="area">Pass the calculated area of the shape.</param>
    /// <param name="shape">Automatically gets the shape from caller methods name.</param>
    private static void Show2DResults(double perimeter, double area, [CallerMemberName] string? shape = null)
    {
      Console.WriteLine();
      if (perimeter != 0)
        Console.WriteLine($"The perimeter of defined {shape} is {perimeter} cm.");
      Console.WriteLine($"The surface area of defined {shape} is {area} cm².");
      ProgramMethods.UserAnswer = ProgramMethods.AskToContinue($"If you want to calculate another {shape}, type 'y'.", "If you want to select other shape, type 's'.");
    }

    /// <summary>
    /// Outputs calculation results of 3D shape to console.
    /// </summary>
    /// <param name="radius">Define radius of the cylinder.</param>
    /// <param name="height">Define height of the cylinder.</param>
    private static void ShowResults(double surfaceArea, double volume, [CallerMemberName] string? shape = null)
    {
      Console.WriteLine($"\nThe surface area of the {shape} is {surfaceArea} cm².");
      Console.WriteLine($"The volume of the {shape} is {volume} cm³.");
      ProgramMethods.UserAnswer = ProgramMethods.AskToContinue($"If you want to calculate another {shape}, type 'y'.", "If you want to select other shape, type 's'.");
    }
  }
}