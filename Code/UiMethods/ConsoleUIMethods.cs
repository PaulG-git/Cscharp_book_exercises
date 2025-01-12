namespace Exercises.UiMethods
{
  public class ConsoleUIMethods
  {
    /// <summary>
    /// Clears the current line. If last line ended with 'new line' use 'ClearPreviousLine' instead.
    /// </summary>
    public static void ClearCurrentConsoleLine()
    {
      Console.SetCursorPosition(0, Console.CursorTop);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop);
    }

    /// <summary>
    /// Clears the previous last line.
    /// </summary>
    public static void ClearPreviousLine()
    {
      Console.SetCursorPosition(0, Console.CursorTop - 1);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop);
    }

    /// <summary>
    /// Clears current and previous line.
    /// </summary>
    public static void ClearLastTwoLines()
    {
      Console.SetCursorPosition(0, Console.CursorTop);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop - 1);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop);
    }

    /// <summary>
    /// Clears specified number of lines.
    /// </summary>
    /// <param name="x">Specify numbers of lines to delete. Current line included.</param>
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
