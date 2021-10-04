using System;

namespace Module_4
{
	class Program
	{

		static void Main()
		{
            (string Name, string Surname,
            string LogIn, int LoginSize,
            bool HasPet, double Age,
            string[] FavColors) User;
            for (int k = 0; k < 3; k++)
            { 
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.Surname = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.LogIn = Console.ReadLine();
                User.LoginSize = User.LogIn.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                User.HasPet = (Console.ReadLine().ToLower() == "да") ? true : false;
                Console.WriteLine("Введите возраст пользователя");
                bool isCorrectAge = double.TryParse(Console.ReadLine(), out User.Age);
                while (!isCorrectAge)
                {
                    Console.WriteLine("Введите возраст пользователя");
                    isCorrectAge = double.TryParse(Console.ReadLine(), out User.Age);
                }
                User.FavColors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                Console.WriteLine();
                for (int i = 0; i < User.FavColors.Length; i++)
                {
                    Console.WriteLine("Введите любимый цвет №" + (i + 1));
                    User.FavColors[i] = Console.ReadLine();
                }
            }
        }
	}



}
