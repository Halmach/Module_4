using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {
            int[,] numbers = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int num = 0;
            for (int i = 0; i < numbers.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < numbers.GetUpperBound(1) + 1; j++)
                {
                    num = (numbers[i,j] > 0) ? num + 1 : num;
                }
            }  
            
            Console.WriteLine("Количество положительных чисел: " + num);

        }
    }
    
}
