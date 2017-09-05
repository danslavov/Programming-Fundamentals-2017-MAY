namespace P12_TestNumbers
{
	using System;

	public class P12_TestNumbers
	{
		public static void Main()
		{
			var firstNumber = int.Parse(Console.ReadLine());
			var secondNumber = int.Parse(Console.ReadLine());
			var maxNumber = int.Parse(Console.ReadLine());
			var sum = 0;
			var combinations = 0;


			for (int i = firstNumber; i > 0; i--)
			{
				for (int j = 1; j <= secondNumber; j++)
				{
					sum += 3 * i * j;
					combinations++;

					if (sum >= maxNumber)
					{
						Console.WriteLine($"{combinations} combinations\n" +
							$"Sum: {sum} >= {maxNumber}");
						return;
					}
				}
			}

			Console.WriteLine($"{combinations} combinations\n" +
							$"Sum: {sum}");
		}
	}
}
