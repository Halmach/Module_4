using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            //Console.WriteLine("Последняя буква вашего имени: " + name[name.Length - 1]);

        }
    }
    
}
