using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //var color = Console.ReadLine();
            int t = 0;
            do
            {
                Console.WriteLine("Iteration {0}", t);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
                t++;
            }
            while (t < 3);
        }
    }
}
