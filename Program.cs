using System;

namespace Module_4
{
    class Program
    {
          
        static void Main()
        {     
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            foreach (var character in name)
            {
                Console.Write(character + " ");
            }
            Console.WriteLine("Последняя буква вашего имени: " + name[name.Length - 1]);

        }
    }
    
}
