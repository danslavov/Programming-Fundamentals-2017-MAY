namespace P05_FibonacciNumbers
{
	using System;

	public class P05_FibonacciNumbers_iteration
	{
		public static int GetFibonacciNumbers(int n)
		{
			int nMinusOne = 0;
			int nMinusTwo = 1;
			int current = 0;
			for (int i = 0; i <= n; i++)
			{
				current = nMinusOne + nMinusTwo;
				nMinusTwo = nMinusOne;
				nMinusOne = current;
			}
			return current;
		}

		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(GetFibonacciNumbers(n));
		}
	}
}
