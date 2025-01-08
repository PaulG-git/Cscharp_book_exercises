namespace Exercises.UiMethods
{
  public class ConsoleUIMethods
  {
    public static void ClearCurrentConsoleLine()
    {
      Console.SetCursorPosition(0, Console.CursorTop);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop);
    }

    public static void ClearPreviousLine()
    {
      Console.SetCursorPosition(0, Console.CursorTop - 1);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop);
    }

    public static void ClearLastTwoLines()
    {
      Console.SetCursorPosition(0, Console.CursorTop);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop - 1);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop);
    }

    public static void ClearLastXLines(int x)
    {
      for (int i = 0; i < x; i++)
      {
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop - 1);
      }
    }
  }
}
