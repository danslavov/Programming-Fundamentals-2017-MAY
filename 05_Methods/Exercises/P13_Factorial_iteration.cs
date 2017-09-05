namespace P13_Factorial
{
	using System;
	using System.Numerics;

	public class P13_Factorial_iteration
	{
		public static BigInteger Factorial(int n)
		{
			BigInteger result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}

		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(Factorial(n));
		}
	}
}
