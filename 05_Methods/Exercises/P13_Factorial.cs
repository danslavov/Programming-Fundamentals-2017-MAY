namespace P13_Factorial
{
	using System;
	using System.Numerics;

	public class P13_Factorial
	{
		public static BigInteger Factorial(int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			else
			{
				return n * Factorial(n - 1);
			}
		}

		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(Factorial(n));
		}
	}
}
