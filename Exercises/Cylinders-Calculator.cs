internal class CylindersCalculator
{
    private static void Main(string[] args)
    {
        int r;
        int h;
        double Volume;
        double SurfaceArea;
        int UserAnswer;
        string? input;

    Start:
        FirstInput();
        Calculations();
        Output();
    BackToInput:
        UserInput();
        switch (EndHandler())
        {
            case 0:
                break;
            case 1:
                goto Start;
            case 2:
                goto BackToInput;
        }

        void FirstInput()
        {
        Return1:
            Console.Write("Define the radius of the cylinder in cm: ");
            input = Console.ReadLine();
            if (input == null | !int.TryParse(input, out int _))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid value.");
                goto Return1;
            }
            r = Convert.ToInt32(input);

            bool looped = false;
        Return2:
            Console.Write("Define the height of the cylinder in cm: ");
            input = Console.ReadLine();
            if (input == null | !int.TryParse(input, out int _))
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, currentLineCursor - 2);
                if (looped == true)
                {
                    Console.SetCursorPosition(0, currentLineCursor - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, currentLineCursor - 1);
                }
                else
                {
                    Console.SetCursorPosition(0, currentLineCursor - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, currentLineCursor - 1);
                    Console.WriteLine("Please enter a valid value.");
                    Console.SetCursorPosition(0, currentLineCursor);
                    looped = true;
                }
                goto Return2;
            }
            h = Convert.ToInt32(input);
        }

        void Calculations()
        {
            Volume = Math.PI * r * r * h;
            SurfaceArea = 2 * Math.PI * r * (r + h);
        }

        void Output()
        {
            Console.WriteLine($"The cylinder has an radius of {r} cm and height of {h} cm.");
            Console.WriteLine($"The surface area of the cylinder is {SurfaceArea} cm².");
            Console.WriteLine($"The volume of the cylinder is {Volume} cm³.");
            Console.WriteLine();
            Console.WriteLine("Do you want to define a new cylinder? Type 'y' for 'yes' or 'n' for 'no'.");
        }

        void UserInput()
        {
            UserAnswer = Convert.ToInt32(Console.ReadKey().Key);
        }

        int EndHandler()
        {
            switch (UserAnswer)
            {
                case 89:
                    Console.Clear();
                    return 1;

                case 78:
                    return 0;

                default:
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine("You entered the wrong answer! Please answer with 'y' for 'yes' or 'n' for 'no'.");
                    return 2;
            }
        }
    }
}