namespace Exercises.CalculationMethods
{
  internal class CylinderCalculationMethods
  {
    public static double CalculateVolume(int radius, int height)
    {
      return Math.PI * Math.Pow(radius, 2) * height;
    }

    public static double CalculateSurfaceArea(int radius, int height) 
    {
      return 2 * Math.PI * radius * (radius + height);
    }
  }
}
