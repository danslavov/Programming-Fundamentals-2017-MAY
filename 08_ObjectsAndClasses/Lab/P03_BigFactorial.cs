namespace P03_BigFactorial
{
	using System;
	using System.Numerics;

	public class P03_BigFactorial
	{
		public static void Main()
		{
			var input = int.Parse(Console.ReadLine());
			BigInteger factorial = 1;

			for (int i = 1; i <= input; i++)
			{
				factorial *= i;
			}

			Console.WriteLine(factorial);
		}
	}
}
