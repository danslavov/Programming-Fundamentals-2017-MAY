namespace P08_MultiplyEvensByOdds
{
	using System;

	public class P08_MultiplyEvensByOdds
	{
		public static int GetOddSum (int n)
		{
			int sum = 0;
			while (Math.Abs(n) > 0)
			{
				int digit = n % 10;
				if (digit % 2 != 0)
				{
					sum += digit;
				}
				n /= 10;
			}
			return sum;
		}

		public static int GetEvenSum (int n)
		{
			int sum = 0;
			while (Math.Abs(n) > 0)
			{
				int digit = n % 10;
				if (digit % 2 == 0)
				{
					sum += digit;
				}
				n /= 10;
			}
			return sum;
		}

		public static void Main()
		{
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine(GetOddSum(number) * GetEvenSum(number));
		}
	}
}
