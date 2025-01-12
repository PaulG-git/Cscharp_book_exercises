using Exercises;
using Exercises.CalculationMethods;
using Exercises.UiMethods;
using System.Runtime.CompilerServices;

namespace ShapePrinter
{
  internal class ShapePrinterClass
  {
    /// <summary>
    /// Stack parameter to track rerun shape, choose different shape, return to main menu or quit program. 
    /// </summary>
    private static (bool, bool) UserAnswer;

    /// <summary>
    /// Collection of available shapes to print.
    /// </summary>
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(Tree), Tree)}
      
      
      
      
      //ADD MORE SHAPES!!!!!!!




    };
    
    /// <summary>
    /// This methods starts a shape printing program. 
    /// </summary>
    public static void ShapePrinterMain()
    {
      do
      {
        Console.WriteLine("Welcome to this shape printing program.");
        Console.WriteLine("Which shape do you want to draw?");
        foreach (var action in _actions)
        {
          Console.WriteLine(action.Key + ". " + action.Value.Item1);
        }

        _actions[InputMethods.CheckInput(_actions.Count, "Wrong input. Please specify the shape that you want to draw: ")].Item2.Invoke();
      } while (UserAnswer.Item2);
    }

    /// <summary>
    /// Print out standard text for shape printer.
    /// </summary>
    /// <param name="columns">Define maximum columns you can work with</param>
    /// <param name="maxrows">Define maximum rows the user can input</param>
    /// <param name="shape">Name of the shape determined from running method name</param>
    /// <returns>Number of rows specified by the user.</returns>
    private static int StartingText(int columns, int maxrows, [CallerMemberName] string? shape = null)
    {
      Console.WriteLine($"This program prints out a {shape} of the specified size. Maximum size of the tree depends on console width.");
      Console.WriteLine($"Current console width is: {columns}. Maximum row count is: {maxrows}");
      int rows = NumberInputMethods.GetInputPositiveInt($"Please, specify how many rows do you want the {shape} to be: ", maxrows);
      Console.Clear();
      return rows;
    }

    /// <summary>
    /// Ask the user to print new same shape, print other shape, return to main menu or quit program etirely.
    /// </summary>
    /// <param name="shape">Name of the shape determined from running method name</param>
    private static (bool, bool) AskNextShape([CallerMemberName] string? shape = null)
    {
      Console.WriteLine($"\nIf you want to print a new {shape}, type 'y'.");
      Console.WriteLine("If you want to print some other shape, type 's'.");
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
          MainProgram.ExitProgram();
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
        looped = InputMethods.WrongAnswer();
      }
    }

    /// <summary>
    /// Prints shape of a tree to the console.
    /// </summary>
    private static void Tree()
    {
      do
      {
        int columns = Console.BufferWidth;
        if (!NumberInputMethods.IsEven(columns))
          columns -= 1;
        int maxrows = columns / 2;
        int rows = StartingText(columns, maxrows);

        for (int i = 1; i <= rows; i++)
        {
          string whitespace = new(' ', maxrows - i);
          string structure = new('*', (i * 2) - 1);
          Console.Write(whitespace);
          Console.Write(structure);
          Console.Write(whitespace + "\n");
        }
        UserAnswer = AskNextShape();
      } while (UserAnswer.Item1);
    }
  }
}
