using Exercises.UiMethods;

namespace Exercises.CalculationMethods
{
  internal class NumberInputMethods
  {
    public static int GetInputPositiveInt(string prompt, int maxValue = int.MaxValue)
    {
      bool looped = false;
      while (true)
      {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        
        if (int.TryParse(input, out int value) && value > 0 && value <= maxValue)
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

    public static bool IsEven(int value)
    {
      if (value % 2 == 0)
        return true;
      return false;
    }
  }
}
