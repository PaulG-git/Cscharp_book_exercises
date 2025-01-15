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
    /// Calculates the perimeter of an triangle and outputs triangle type.
    /// </summary>
    /// <param name="width">Define width of the triangle.</param>
    /// <param name="height">Define height of the tiangle.</param>
    /// <param name="angle">Define the angle of the triangle.</param>
    /// <returns>Returns the perimeter of defined triangle in cm.</returns>
    public static double TrianglePerimeter(int width, int height, int angle)
    {
      double angleRadians = angle * (MathF.PI / 180);
      string bySideType;
      string byAngleType;
      double sideA;
      double sideB;
      double b = height / Math.Tan(angleRadians);

      if (angle == 90 || b == width)
      {
        byAngleType = "Right";
        sideA = height;
        sideB = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
      }
      else if (b < width)
      {
        sideA = height / Math.Sin(angleRadians);
        sideB = Math.Sqrt(Math.Pow(width - b, 2) + Math.Pow(height, 2));
        if (sideA == sideB)
          byAngleType = "Right";
        else
          byAngleType = "Acute";
      }
      else 
      {
        byAngleType = "Obtuse";
        sideA = height / Math.Sin(angleRadians);
        sideB = Math.Sqrt(Math.Pow(b - width, 2) + Math.Pow(height, 2));
      }

      if (sideA == sideB && sideA == width)
      {
        bySideType = "Equilateral";
        byAngleType = "Acute";
      }
      else if (sideA == sideB || sideA == width || sideB == width)
        bySideType = "Isoceles";
      else
        bySideType = "Scalene";

      Console.WriteLine($"\nDefined triangle is an '{bySideType} {byAngleType} Triangle'.");
      return sideA + sideB + width;
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
    /// Calculates the perimeter of an circle.
    /// </summary>
    /// <param name="radius">Define radius of the circle.</param>
    /// <returns>Returns the perimeter of defined circle in cm.</returns>
    public static double CirclePerimeter(int radius)
    {
      return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Calculates the area of an circle.
    /// </summary>
    /// <param name="radius">Define radius of the circle.</param>
    /// <returns>Returns the area of defined circle in cm.</returns>
    public static double CircleArea(int radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>
    /// Calculates the perimeter of an ellipse.
    /// </summary>
    /// <param name="longRadius">Define radius of long axis of the ellipse.</param>
    /// <param name="shortRadius">Define radius of short axis of the ellipse.</param>
    /// <returns>Returns the perimeter of defined ellipse in cm.</returns>
    /// <remarks>
    /// If the 'long radius' is not longer than 3 times the 'short radius', the second Ramanujan's approximation formula is used.
    /// Otherwise it averages both Ramanujan's approximation formulas to best fit the result compared to ifinite series integral formula.
    /// </remarks>
    /// <seealso cref="https://www.mathsisfun.com/geometry/ellipse-perimeter.html"/>
    public static double EllipsePerimeter(int longRadius, int shortRadius)
    {
      double h = Math.Pow(longRadius - shortRadius, 2) / Math.Pow(longRadius + shortRadius, 2);
      double approx2 = Math.PI * (longRadius + shortRadius) * (1 + ((3 * h) / (10 + Math.Sqrt(4 - (3 * h)))));
      double approx1 = approx2;
      
      if (longRadius / shortRadius >= 3)
      {
        approx1 = Math.PI * (3 * (longRadius + shortRadius) - Math.Sqrt(((3 * longRadius) + shortRadius) * (longRadius + (3 * shortRadius))));
      }
      
      return (approx2 + approx1) / 2;
    }

    /// <summary>
    /// Calculates the area of an ellipse.
    /// </summary>
    /// <param name="longRadius">Define radius of long axis of the ellipse.</param>
    /// <param name="shortRadius">Define radius of short axis of the ellipse.</param>
    /// <returns>Returns the area of defined ellipse in cm.</returns>
    public static double EllipseArea(int longRadius, int shortRadius)
    {
      return Math.PI * longRadius * shortRadius;
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
