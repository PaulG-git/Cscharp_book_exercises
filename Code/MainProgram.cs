using CylindersCalculator.UiMethods;

namespace CylindersCalculator
{
  internal class MainProgram
  {
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(CalculatorPaul), CalculatorPaul.CalculatorPaulMain)},
      {2, new (nameof(CalculatorRowan), CalculatorRowan.CalculatorRowanMain)},
      {3, new (nameof(CylindersCalculatorClassOld), CylindersCalculatorClassOld.CylindersCalculatorClassOldMain)}
    };   
    
    public static void Main()
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
          ConsoleUIMethods.ClearCurrentConsoleLine();
          Console.Write("Wrong input. Please specify the program that you want to run: ");
        }
      }
    }
  }
}