using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylindersCalculator.UiMethods
{
  public class ConsoleUIMethods
  {
    public static void RepositionCursurTopAndClearLine()
    {
      Console.SetCursorPosition(0, Console.CursorTop);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop);
    }
  }
}
