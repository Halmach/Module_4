using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {
            int[] numbers = new int[5] { -1, -100, 40, 20, 10 };
            int num = 0;
            foreach(var item in numbers)
            {
                num = (item > 0) ? num + 1: num;
            }
            Console.WriteLine("Количество положительных чисел: " + num);

        }
    }
    
}
