using System;

namespace Exercises.UiMethods
{
  internal class InputMethods
  {
    /// <summary>
    /// Asks user for input and checks specified conditions. Loops if wrong input is provided.
    /// </summary>
    /// <param name="maxValue">Provide upper limit for acceptable input int.</param>
    /// <param name="promptIfWrong">Specify what text should be printed if provided answer is not an int.</param>
    /// <returns>Returns provided user input as int.</returns>
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
          ConsoleUIMethods.ClearCurrentConsoleLine();
          Console.WriteLine();
        }
        looped = WrongAnswer();
      }
    }

    /// <summary>
    /// Outputs standard message to inform user has inputed wrong answer.
    /// </summary>
    /// <returns>Always returns true if run.</returns>
    public static bool WrongAnswer()
    {
      Console.WriteLine("You entered the wrong answer!");
      Console.WriteLine("Please, provide acceptable answer.");
      return true;
    }
  }
}
