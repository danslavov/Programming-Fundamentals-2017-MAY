namespace P05_FibonacciNumbers
{
	using System;

	public class P05_FibonacciNumbers_recursion
	{
		public static int GetFibonacciNumbers(int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			else
			{
				return GetFibonacciNumbers(n - 1) + GetFibonacciNumbers(n - 2);
			}
				
		}
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(GetFibonacciNumbers(n));
		}
	}
}
