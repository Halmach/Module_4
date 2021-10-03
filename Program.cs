using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for(int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for(int j = 0; j <array.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(array[j, i] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine("Последняя буква вашего имени: " + name[name.Length - 1]);

        }
    }
    
}
