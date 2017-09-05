namespace P06_PrimeChecker
{
	using System;

	public class P06_PrimeChecker
	{
		public static bool IsPrime(long n)
		{
			bool isPrime = true;
			if (n <= 1)
			{
				isPrime = false;
			}
			for (long i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					isPrime = false;
					return isPrime;
				}
			}
			return isPrime;
		}

		public static void Main()
		{
			long n = long.Parse(Console.ReadLine());
			Console.WriteLine(IsPrime(n));
		}
	}
}
