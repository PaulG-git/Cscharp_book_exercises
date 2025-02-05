namespace Exercises.UiMethods
{
  internal class ProgramMethods
  {
    /// <summary>
    /// Parameter to track rerun method, return to subprogram, return to main menu or quit program. 
    /// </summary>
    public static (bool, bool) UserAnswer;

    /// <summary>
    /// Asks user for input key and checks specified conditions. Loops if wrong input is provided.
    /// </summary>
    /// <param name="maxValue">Provide upper limit for acceptable input int.</param>
    /// <param name="promptIfWrong">Specify what text should be printed if provided answer is not an int.</param>
    /// <returns>Returns provided user input as int.</returns>
    public static int CheckInputKey(int maxValue, string promptIfWrong)
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
    /// Asks user for input line and checks specified conditions. Loops if wrong input is provided.
    /// </summary>
    /// <param name="maxValue">Provide upper limit for acceptable input int.</param>
    /// <param name="promptIfWrong">Specify what text should be printed if provided answer is not an int.</param>
    /// <returns>Returns provided user input as int.</returns>
    public static int CheckInputLine(int maxValue, string promptIfWrong)
    {
      while (true)
      {
        string? answer = Console.ReadLine();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= maxValue)
        {
          Console.Clear();
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearLastTwoLines();
          Console.Write(promptIfWrong);
        }
      }
    }

    /// <summary>
    /// Asks user to rerun program, exit or return to main menu.
    /// </summary>
    /// <returns>Returns 2 bool values. Bool 1 to choose if loop method or return to subprogram. Bool 2 to determine if return to main menu.</returns>
    public static (bool, bool) AskToContinue(string promptMethod, string? promptSubprogram = null)
    {
      Console.WriteLine($"\n" + promptMethod);
      if (promptSubprogram != null) 
        Console.WriteLine(promptSubprogram);
      Console.WriteLine("If you want to return to main menu, type 'r'.");
      Console.WriteLine("If you want to quit program entirely, type 'n'.");

      bool looped = false;
      while (true)
      {
        char userAnswer = Console.ReadKey().KeyChar;
        if (userAnswer == 'y')
        {
          Console.Clear();
          return (true, true);
        }
        else if (userAnswer == 'n')
        {
          ExitProgram();
        }
        else if (userAnswer == 'r')
        {
          Console.Clear();
          return (false, false);
        }
        else if (userAnswer == 's')
        {
          Console.Clear();
          return (false, true);
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

    /// <summary>
    /// Exits program immediately.
    /// </summary>
    public static void ExitProgram()
    {
      Environment.Exit(1);
    }

    public static void ExitSubProgram()
    {
      Console.Clear();
      UserAnswer = (false, false);
    }
  }
}
