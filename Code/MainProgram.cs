using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace CylindersCalculator
{
  internal class MainProgram
  {
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(CylindersCalculatorClass), CylindersCalculatorClass.CylindersCalculatorClassMain)},
      {2, new (nameof(CalculatorRowan), CalculatorRowan.CalculatorRowanMain)}
    };   
    
    private static void Main()
    {
      Console.WriteLine("Which program do you want to run?");
      foreach (var action in _actions)
      {
        Console.WriteLine(action.Key + ". " + action.Value.Item1);
      }

      _actions[CheckInput()].Item2.Invoke();
    }

    private static int CheckInput()
    {
      while (true)
      {
        string? answer = Console.ReadKey().KeyChar.ToString();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= _actions.Count && evaluatedAnswer > 0)
        {
          Console.Clear();
          return evaluatedAnswer;
        }
        else
        {
          Console.SetCursorPosition(0, Console.CursorTop);
          Console.Write(new string(' ', Console.WindowWidth));
          Console.SetCursorPosition(0, Console.CursorTop);
          Console.Write("Wrong input. Please specify the program that you want to run: ");
        }
      }
    }
  }
}