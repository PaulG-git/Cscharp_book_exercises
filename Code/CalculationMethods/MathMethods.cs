namespace Exercises.CalculationMethods
{
  internal class MathMethods
  {
    /// <summary>
    /// Converts given angle in degrees to angle in radians. 
    /// </summary>
    /// <param name="angle">Define the angle in degrees.</param>
    /// <returns>Returns the angle in radians.</returns>
    public static double AngleToRadians(double angle) { return angle * (Math.PI / 180); }

    /// <summary>
    /// Converts given angle in radians to angle in degrees. 
    /// </summary>
    /// <param name="angle">Define the angle in radians.</param>
    /// <returns>Returns the angle in radians.</returns>
    public static double AngleToDegrees(double angle) { return angle * (180 / Math.PI); }
  }

  /// <summary>
  /// This class contains predefined trigonometric functions calculations. The letter after underscore in the name (mnemonics) indicates which part is being calculated.
  /// </summary>
  internal class Trigonometrics
  {
    /// <summary>
    /// Calculates the hypotenuse (long) side of the triangle using the angle (in degrees) and side opposite to the angle.
    /// </summary>
    /// <param name="opposite">Define the length of the side opposite to the angle.</param>
    /// <param name="angle">Define the angle in degrees.</param>
    /// <returns>Returns the length of the hypotenuse (long) side of the triangle as double.</returns>
    public static double SOH_H(double opposite, double angle) { return opposite / Math.Sin(MathMethods.AngleToRadians(angle)); }

    /// <summary>
    /// Calculates the opposite side of the triangle using the angle (in degrees) and hypotenuse (long) side of the triangle.
    /// </summary>
    /// <param name="longSide">Define the length of the hypotenuse (long) side of the triangle.</param>
    /// <param name="angle">Define the angle in degrees.</param>
    /// <returns>Returns the length of the opposite side to the angle as double.</returns>
    public static double SOH_O(double longSide, double angle) { return longSide * Math.Sin(MathMethods.AngleToRadians(angle)); }

    /// <summary>
    /// Calculates the angle (in degrees) using the opposite and hypotenuse (long) sides of the triangle.
    /// </summary>
    /// <param name="longSide">Define the length of the hypotenuse (long) side of the triangle.</param>
    /// <param name="opposite">Define the length of the side opposite to the angle.</param>
    /// <returns>Returns the angle (in degrees) as double.</returns>
    public static double SOH_S(double longSide, double opposite) { return MathMethods.AngleToDegrees(Math.Asin(opposite / longSide)); }

    /// <summary>
    /// Calculates the hypotenuse (long) side of the triangle using the angle (in degrees) and side adjecent to the angle.
    /// </summary>
    /// <param name="adjecent">Define the length of the side adjecent to the angle.</param>
    /// <param name="angle">Define the angle in degrees.</param>
    /// <returns>Returns the length of the hypotenuse (long) side of the triangle as double.</returns>
    public static double CAH_H(double adjecent, double angle) { return adjecent / Math.Cos(MathMethods.AngleToRadians(angle)); }

    /// <summary>
    /// Calculates the adjecent side of the triangle using the angle (in degrees) and hypotenuse (long) side of the triangle.
    /// </summary>
    /// <param name="longSide">Define the length of the hypotenuse (long) side of the triangle.</param>
    /// <param name="angle">Define the angle in degrees.</param>
    /// <returns>Returns the length of the adjecent side to the angle as double.</returns>
    public static double CAH_A(double longSide, double angle) { return longSide * Math.Cos(MathMethods.AngleToRadians(angle)); }

    /// <summary>
    /// Calculates the angle (in degrees) using the adjecent and hypotenuse (long) sides of the triangle.
    /// </summary>
    /// <param name="longSide">Define the length of the hypotenuse (long) side of the triangle.</param>
    /// <param name="adjecent">Define the length of the side adjecent to the angle.</param>
    /// <returns>Returns the angle (in degrees) as double.</returns>
    public static double CAH_C(double longSide, double adjecent) { return MathMethods.AngleToDegrees(Math.Acos(adjecent / longSide)); }

    /// <summary>
    /// Calculates the adjecent side of the triangle using the angle (in degrees) and side opposite to the angle.
    /// </summary>
    /// <param name="opposite">Define the length of the side opposite to the angle.</param>
    /// <param name="angle">Define the angle in degrees.</param>
    /// <returns>Returns the length of the adjecent side of the triangle as double.</returns>
    public static double TOA_A(double opposite, double angle) { return opposite / Math.Tan(MathMethods.AngleToRadians(angle)); }

    /// <summary>
    /// Calculates the opposite side of the triangle using the angle (in degrees) and adjecent side of the triangle.
    /// </summary>
    /// <param name="adjecent">Define the length of the side adjecent of the triangle.</param>
    /// <param name="angle">Define the angle in degrees.</param>
    /// <returns>Returns the length of the opposite side to the angle as double.</returns>
    public static double TOA_O(double adjecent, double angle) { return adjecent * Math.Tan(MathMethods.AngleToRadians(angle)); }

    /// <summary>
    /// Calculates the angle (in degrees) using the opposite and adjecent sides of the triangle.
    /// </summary>
    /// <param name="opposite">Define the length of the side opposite side of the triangle.</param>
    /// <param name="adjecent">Define the length of the side adjecent to the angle.</param>
    /// <returns>Returns the angle (in degrees) as double.</returns>
    public static double TOA_T(double opposite, double adjecent) { return MathMethods.AngleToDegrees(Math.Atan(opposite / adjecent)); }
  }
}
