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

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.Surname = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.LogIn = Console.ReadLine();
            User.LoginSize = User.LogIn.Length;
        }
	}



}
