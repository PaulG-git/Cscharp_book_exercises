using Exercises.CalculationMethods;
using Exercises.UiMethods;
using System.Runtime.CompilerServices;

namespace ShapePrinter
{
  internal class ShapePrinterClass
  {
    /// <summary>
    /// Collection of available shapes to print.
    /// </summary>
    private static readonly Dictionary<int, (string, Action)> _shapes = new()
    {
      {1, new (nameof(Tree), Tree)},
      {0, ("Return to main menu", ProgramMethods.ExitSubProgram)}
      
      
      
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
        foreach (var action in _shapes)
        {
          if (action.Key == 0)
            Console.WriteLine();
          Console.WriteLine(action.Key + ". " + action.Value.Item1);
        }

        _shapes[ProgramMethods.CheckInput(_shapes.Count, "Wrong input. Please specify the shape that you want to draw: ")].Item2.Invoke();
      } while (ProgramMethods.UserAnswer.Item2);
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
        ProgramMethods.UserAnswer = ProgramMethods.AskToContinue($"\nIf you want to print a new tree, type 'y'.", "If you want to print some other shape, type 's'.");
      } while (ProgramMethods.UserAnswer.Item1);
    }
  }
}
