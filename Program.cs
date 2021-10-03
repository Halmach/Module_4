using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {     
            Console.WriteLine("Введите свое имя");
            var name = (Console.ReadLine());
            Console.WriteLine("Ваше имя по буквам в обратном порядке:");
            var chNum = name.Length;
            for(int i = chNum - 1; i >= 0; i --)
            {
                Console.Write(name[i] + " ");
            }
            //Console.WriteLine("Последняя буква вашего имени: " + name[name.Length - 1]);

        }
    }
    
}
