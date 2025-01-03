using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace CylindersCalculator
{
  internal class MainProgram
  {
    static Dictionary<int, (string, Action)> _actions = new Dictionary<int, (string, Action)>();
    public static void FillDictionary()
    {
      _actions.Add(1, (nameof(CylindersCalculatorClass), CylindersCalculatorClass.CylindersCalculatorClassMain));
      _actions.Add(2, (nameof(CalculatorRowan), CalculatorRowan.CalculatorRowanMain));
    }
    
    private static void Main()
    {
      FillDictionary();
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