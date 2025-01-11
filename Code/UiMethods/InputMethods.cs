using System;

namespace Exercises.UiMethods
{
  internal class InputMethods
  {
    public static int CheckInput(int maxValue, string promptIfWrong)
    {
      while (true)
      {
        string? answer = Console.ReadKey().KeyChar.ToString();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= maxValue)
        {
          Console.Clear();
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearCurrentConsoleLine();
          Console.Write(promptIfWrong);
        }
      }
    }

    /// <summary>
    /// Asks user to rerun program, exit or return to main menu.
    /// </summary>
    /// <returns>Returns bool or redirects back to main program.</returns>
    public static bool AskToContinue(string prompt)
    {
      Console.WriteLine("\n" + prompt);
      Console.WriteLine("Type 'y' for 'yes' or 'n' for 'no'. To go back to main menu, please press 'r'.");

      bool looped = false;
      while (true)
      {
        char userAnswer = Console.ReadKey().KeyChar;
        if (userAnswer == 'y')
        {
          Console.Clear();
          return true;
        }
        else if (userAnswer == 'n')
        {
          MainProgram.ExitProgram();
        }
        else if (userAnswer == 'r')
        {
          Console.Clear();
          return false;
          
        }

        if (looped)
        {
          ConsoleUIMethods.ClearLastXLines(2);
        }
        else
        {
          ConsoleUIMethods.ClearLastTwoLines();
        }
        looped = WrongAnswer();
      }
    }

    public static bool WrongAnswer()
    {
      Console.WriteLine("You entered the wrong answer!");
      Console.WriteLine("Please answer with 'y' for 'yes' or 'n' for 'no'. To return to main menu press 'r'.");
      return true;
    }
  }
}
