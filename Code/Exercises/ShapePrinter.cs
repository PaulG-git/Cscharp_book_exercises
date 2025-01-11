using Exercises.CalculationMethods;
using Exercises.UiMethods;

namespace ShapePrinter
{
  internal class ShapePrinterClass  //Add more shapes
  {
    /// <summary>
    /// Collection of available shapes to print.
    /// </summary>
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(Tree), Tree)}
      //add more
    };
    
    /// <summary>
    /// This methods starts a shape printing program. 
    /// </summary>
    public static void ShapePrinterMain()
    {
      Console.WriteLine("Welcome to this shape printing program.");
      Console.WriteLine("Which shape do you want to draw?");
      foreach (var action in _actions)
      {
        Console.WriteLine(action.Key + ". " + action.Value.Item1);
      }

      _actions[InputMethods.CheckInput(_actions.Count, "Wrong input. Please specify the shape that you want to draw: ")].Item2.Invoke();
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

        Console.WriteLine("This program prints out a tree of the specified size. Maximum size of the tree depends on console width.");
        Console.WriteLine($"Current console width is: {Console.BufferWidth}. Maximum row count is: {columns / 2}");
        int rows = NumberInputMethods.GetInputPositiveInt("Please, specify how many rows do you want the tree to be: ", columns / 2);

        Console.Clear();

        for (int i = 1; i <= rows; i++)
        {
          string whitespace = new (' ', (columns / 2) - i);
          string structure = new ('*', (i * 2) - 1);
          Console.Write(whitespace);
          Console.Write(structure);
          Console.Write(whitespace + "\n");
        }
      } while (InputMethods.AskToContinue("Do you want to print a new tree?"));
    }
  }
}
