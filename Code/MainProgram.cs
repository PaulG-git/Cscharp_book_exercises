using Exercises.UiMethods;
using CylinderCalculator;
using Calculator;
using ShapePrinter;
using FizzBuzz;

namespace Exercises
{
  internal class MainProgram
  {
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(CylinderCalculatorPaul), CylinderCalculatorPaul.CalculatorPaulMain)},
      {2, new (nameof(CylinderCalculatorRowan), CylinderCalculatorRowan.CalculatorRowanMain)},
      {3, new (nameof(CylindersCalculatorClassOld), CylindersCalculatorClassOld.CylindersCalculatorClassOldMain)},
      {4, new (nameof(CalculatorClass), CalculatorClass.CalculatorMain)},
      {5, new (nameof(ShapePrinterClass), ShapePrinterClass.ShapePrinterMain)},
      {6, new (nameof(FizzBuzzClass), FizzBuzzClass.FizzBuzzMain)}
    };

    public static void Main()
    {
      Console.WriteLine("Which program do you want to run?");
      foreach (var action in _actions)
      {
        Console.WriteLine(action.Key + ". " + action.Value.Item1);
      }

      _actions[InputMethods.CheckInput(_actions.Count, "Wrong input. Please specify the program that you want to run: ")].Item2.Invoke();
    }
  }
}