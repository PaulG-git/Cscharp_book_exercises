using Exercises.UiMethods;

namespace Exercises.CalculationMethods
{
  internal class ShapeCalculationMethods
  {
    /// <summary>
    /// Calculates the perimeter of an square.
    /// </summary>
    /// <param name="sideLength">Define sides length of the square.</param>
    /// <returns>Returns the perimeter of defined square in cm.</returns>
    public static int SquarePerimeter(int sideLength)
    { 
      return 4 * sideLength;
    }
    
    /// <summary>
    /// Calculates the area of an square.
    /// </summary>
    /// <param name="sideLength">Define sides length of the square.</param>
    /// <returns>Returns the area of defined square in cm².</returns>
    public static int SquareArea(int sideLength)
    {
      return ((int)Math.Pow(sideLength, 2));
    }

    /// <summary>
    /// Calculates the perimeter of an rectangle.
    /// </summary>
    /// <param name="width">Define width of the rectangle.</param>
    /// <param name="height">Define height of the rectangle.</param>
    /// <returns>Returns the perimeter of defined rectangle in cm.</returns>
    public static int RectanglePerimeter(int width, int height)
    {
      return 2 * (width + height);
    }

    /// <summary>
    /// Calculates the area of an rectangle.
    /// </summary>
    /// <param name="width">Define width of the rectangle.</param>
    /// <param name="height">Define height of the rectangle.</param>
    /// <returns>Returns the area of defined rectangle in cm.</returns>
    public static int RectangleArea(int width, int height)
    {
      return width * height;
    }

    /// <summary>
    /// Calculates the perimeter of an triangle.
    /// </summary>
    /// <param name="width">Define width of the triangle.</param>
    /// <param name="height">Define height of the tiangle.</param>
    /// <param name="angle">Define the angle of the triangle.</param>
    /// <returns>Returns the perimeter of defined triangle in cm.</returns>
    public static double TrianglePerimeter(int width, int height, int angle)
    {
      if (Math.Tan(angle) != height / (width / 2))
      {
        Console.Clear();
        ProgramMethods.UserAnswer.Item1 = true;
        Console.WriteLine("The defined triangle is impossible. Pleas define new triangle!");
        return -1;
      }
      
      double sideA;
      if (angle != 90) 
        sideA = height / Math.Sin(angle);
      else
        sideA = height;
      double sideB = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(sideA, 2));
      return width + sideA + sideB;
    }

    /// <summary>
    /// Calculates the area of an triangle.
    /// </summary>
    /// <param name="width">Define width of the triangle.</param>
    /// <param name="height">Define height of the tiangle.</param>
    /// <returns>Returns the area of defined triangle in cm.</returns>
    public static double TriangleArea(int width, int height)
    {
      return 0.5 * width * height;
    }

    /// <summary>
    /// Calculates the volume of an cylinder.
    /// </summary>
    /// <param name="radius">Define radius of the cylinder.</param>
    /// <param name="height">Define height of the cylinder.</param>
    /// <returns>Returns the volume of defined cylinder in cm³.</returns>
    public static double CylinderVolume(int radius, int height)
    {
      return Math.PI * Math.Pow(radius, 2) * height;
    }

    /// <summary>
    /// Calculates the surface area of an cylinder.
    /// </summary>
    /// <param name="radius">Define radius of the cylinder.</param>
    /// <param name="height">Define height of the cylinder.</param>
    /// <returns>Returns the surface area of defined cylinder in cm².</returns>
    public static double CylinderSurfaceArea(int radius, int height) 
    {
      return 2 * Math.PI * radius * (radius + height);
    }
  }
}
