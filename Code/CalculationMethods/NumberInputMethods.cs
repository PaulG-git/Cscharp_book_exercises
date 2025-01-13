using Exercises.UiMethods;

namespace Exercises.CalculationMethods
{
  internal class NumberInputMethods
  {
    /// <summary>
    /// Asks user for input and checks if input is positive integer. Optional to define maximum value for user input. 
    /// </summary>
    /// <param name="prompt">Define text to be printed to console before asking user for input.</param>
    /// <param name="maxValue">Optional. Define maximum value that user can enter.</param>
    /// <returns>Returns positive integer defined by the user.</returns>
    public static int GetInputPositiveInt(string prompt, int maxValue = int.MaxValue, int minValue = 1)
    {
      bool looped = false;
      while (true)
      {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        
        if (int.TryParse(input, out int value) && value >= minValue && value <= maxValue)
        {
          if (looped)
          {
            ConsoleUIMethods.ClearLastXLines(2);
            Console.Write(prompt + value + "\n");
          }
            return value;
        }
        else 
        {
          if (looped)
          {
            ConsoleUIMethods.ClearLastXLines(2);
            Console.WriteLine("Please enter a valid value.");
          }
          else
          {
            ConsoleUIMethods.ClearPreviousLine();
            Console.WriteLine("Please enter a valid value.");
            looped = true;
          }
        }
      }
    }

    /// <summary>
    /// Determines id specific integer number is even.
    /// </summary>
    /// <param name="value">Define integer number to check.</param>
    /// <returns>Returns bool. True = number is even. False = number is odd.</returns>
    public static bool IsEven(int value)
    {
      if (value % 2 == 0)
        return true;
      return false;
    }
  }
}
