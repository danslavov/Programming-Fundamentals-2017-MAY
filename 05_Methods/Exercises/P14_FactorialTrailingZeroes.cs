namespace P14_FactorialTrailingZeroes
{
	using System;
	using System.Numerics;

	public class P14_FactorialTrailingZeroes
	{
		static BigInteger result = 1;

		public static BigInteger Factorial(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}

		public static int GetTrailingZeroes(BigInteger n)
		{
			int zeroesCount = 0;

			while (true)
			{
				if (n % 10 == 0)
				{
					zeroesCount++;
					n /= 10;
				}
				else
				{
					return zeroesCount;
				}
			}
		}

		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Factorial(n);
			Console.WriteLine(GetTrailingZeroes(result));
		}
	}
}
