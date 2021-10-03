using System;

namespace Module_4
{
	class Program
	{

		static void Main()
		{
			int[,] numbers = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

			int temp;
			for (int k = 0; k < numbers.GetUpperBound(0) + 1; k++)
			{
				for (int i = 0; i < numbers.GetUpperBound(1) + 1; i++)
				{
					for (int j = i + 1; j < numbers.GetUpperBound(1) + 1; j++)
					{
						if (numbers[k, i] > numbers[k, j])
						{
							temp = numbers[k, i];
							numbers[k, i] = numbers[k, j];
							numbers[k, j] = temp;
						}
					}
				}


			}
			for (int k = 0; k < numbers.GetUpperBound(0) + 1; k++)
			{
				Console.Write("{");
				for (int i = 0; i < numbers.GetUpperBound(1) + 1; i++)
				{
					Console.Write(numbers[k, i]);
				}
				Console.WriteLine("}");
			}
		}
	}
    
}
