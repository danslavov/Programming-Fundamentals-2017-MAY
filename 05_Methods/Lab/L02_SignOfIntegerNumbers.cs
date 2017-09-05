namespace P02_SignOfIntegerNumber
{
	using System;

	public class P02_SignOfIntegerNumbers
	{
		public static void PrintSign(int n)
		{
			if (n > 0)
			{
				Console.WriteLine("The number {0} is positive.", n);
			}
			else if (n < 0)
			{
				Console.WriteLine("The number {0} is negative.", n);
			}
			else
			{
				Console.WriteLine("The number {0} is zero.", n);
			}
		}

		public static void Main()
		{
			int number = int.Parse(Console.ReadLine());
			PrintSign(number);
		}
	}
}
