using System;

namespace Module_4
{
	class Program
	{

		static void Main()
		{
            //      (string myName, byte age, DayOfWeek day, string birthdate) anketa;
          //  var (myName, age, day, birthdate) = ("Vasya",(byte)30,DayOfWeek.Wednesday,"22.04.1991");
            (string Name, string Type, double Age, int NameCount) Pet;
            
            Console.WriteLine("What is your pet's name?");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Enter your pet's age");
         
            bool isAgeCorrenct = double.TryParse(Console.ReadLine(), out Pet.Age);
            while (!isAgeCorrenct)
            {
                Console.WriteLine("Enter your pet's age");
                isAgeCorrenct = double.TryParse(Console.ReadLine(), out Pet.Age);
            }
            Console.WriteLine("What is your pet's type?");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("What is your pet's length of name: ");
            Pet.NameCount = checked(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Your pet's name is {0}", Pet.Name);
            Console.WriteLine("Your pet's age is {0}", Pet.Age);
            Console.WriteLine("Your pet's type is " + Pet.Type);
            Console.WriteLine("Your pet's length of name is " + Pet.NameCount);
            Console.ReadKey();
        }
	}

    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }

}
