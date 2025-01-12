namespace Exercises.CalculationMethods
{
  internal class ShapeCalculationMethods
  {
    /// <summary>
    /// Calculates volume of specified cylinder.
    /// </summary>
    /// <param name="radius">Define radius of the cylinder.</param>
    /// <param name="height">Define height of the cylinder.</param>
    /// <returns></returns>
    public static double CylinderVolume(int radius, int height)
    {
      return Math.PI * Math.Pow(radius, 2) * height;
    }

    /// <summary>
    /// Calculates surface area of specified cylinder.
    /// </summary>
    /// <param name="radius">Define radius of the cylinder.</param>
    /// <param name="height">Define height of the cylinder.</param>
    /// <returns></returns>
    public static double CylinderSurfaceArea(int radius, int height) 
    {
      return 2 * Math.PI * radius * (radius + height);
    }
  }
}
