namespace Exercises.CalculationMethods
{
  internal class ShapeCalculationMethods
  {
    public static double CylinderVolume(int radius, int height)
    {
      return Math.PI * Math.Pow(radius, 2) * height;
    }

    public static double CylinderSurfaceArea(int radius, int height) 
    {
      return 2 * Math.PI * radius * (radius + height);
    }
  }
}
