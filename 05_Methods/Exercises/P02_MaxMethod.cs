namespace P02_MaxMethod
{
	using System;

	public class P02_MaxMethod
	{
		public static void GetMax(int first, int second, int third)
		{
			if (first > second)
			{
				if (first > third)
				{
					Console.WriteLine(first);
				}
				else
				{
					Console.WriteLine(third);
				}
			}
			else if (second > third)
			{
				Console.WriteLine(second);
			}
			else
			{
				Console.WriteLine(third);
			}
		}
		public static void Main()
		{
			var firstNumber = int.Parse(Console.ReadLine());
			var secondNumber = int.Parse(Console.ReadLine());
			var thirdNumber = int.Parse(Console.ReadLine());

			GetMax(firstNumber, secondNumber, thirdNumber);
		}
	}
}
