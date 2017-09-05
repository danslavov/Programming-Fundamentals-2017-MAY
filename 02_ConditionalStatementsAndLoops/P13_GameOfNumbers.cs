namespace P13_GameOfNumbers
{
	using System;

	public class P13_GameOfNumbers
	{
		public static void Main()
		{
			var firstNumber = int.Parse(Console.ReadLine());
			var secondNumber = int.Parse(Console.ReadLine());
			var magicNumber = int.Parse(Console.ReadLine());
			var magicFirst = -1;
			var magicSecond = 0;
			var counter = 0;


			for (int i = firstNumber; i <= secondNumber; i++)
			{
				for (int j = firstNumber; j <= secondNumber; j++)
				{
					counter++;

					if (i + j == magicNumber)
					{
						magicFirst = i;
						magicSecond = j;
					}
				}
			}

			if (magicFirst != -1)
			{
				Console.WriteLine($"Number found! " +
					$"{magicFirst} + {magicSecond} = {magicNumber}");
			}
			else
			{
				Console.WriteLine($"{counter} combinations - " +
					$"neither equals {magicNumber}");
			}
		}
	}
}
