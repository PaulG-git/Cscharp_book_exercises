using Exercises.UiMethods;
using ShapeCalculator;
using Calculator;
using ShapePrinter;
using FizzBuzz;
using ArrayReverse;
using RecursionPractice;
using RollDice;

namespace Exercises
{
  /// <summary>
  /// Main startup program class.
  /// </summary>
  internal class MainProgram
  {
    /// <summary>
    /// Collection of all available programs.
    /// </summary>
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(ShapeCalculatorPaul), ShapeCalculatorPaul.ShapeCalculatorPaulMain)},
      {2, new (nameof(CylinderCalculatorRowan), CylinderCalculatorRowan.CalculatorRowanMain)},
      {3, new (nameof(CylindersCalculatorClassOld), CylindersCalculatorClassOld.CylindersCalculatorClassOldMain)},
      {4, new (nameof(CalculatorClass), CalculatorClass.CalculatorMain)},
      {5, new (nameof(ShapePrinterClass), ShapePrinterClass.ShapePrinterMain)},
      {6, new (nameof(FizzBuzzClass), FizzBuzzClass.FizzBuzzMain)},
      {7, new (nameof(ArrayReverseClass), ArrayReverseClass.ArrayReverseMain)},
      {8, new (nameof(RecursionPracticeClass), RecursionPracticeClass.RecursionFibonacciSequenceMain)},
      {9, new (nameof(RollDiceClass), RollDiceClass.RollDiceMain)},
      {0, new ("Exit program", ProgramMethods.ExitProgram)}
    };
    
    /// <summary>
    /// Main startup program.
    /// </summary>
    public static void Main()
    {
      while (true)
      {
        Console.WriteLine("Which program do you want to run?");
        foreach (var action in _actions)
        {
          if (action.Key == 0)
            Console.WriteLine();
          Console.WriteLine(action.Key + ". " + action.Value.Item1);
        }

        _actions[ProgramMethods.CheckInput(_actions.Count, "Wrong input. Please specify the program that you want to run: ")].Item2.Invoke();
      }
    }
  }
}