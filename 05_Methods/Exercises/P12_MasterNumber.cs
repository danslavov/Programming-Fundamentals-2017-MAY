namespace P12_MasterNumber
{
	using System;

	public class P12_MasterNumber
	{
		public static bool IsPalindrome(string n)
		{
			for (int i = 0; i < n.Length / 2; i++)
			{
				if (n[i] != n[n.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}

		public static bool DivisibleAndEven(string n)
		{
			bool hasEvenDigit = false;
			int sumOfDigits = 0;
			foreach (int symbol in n)
			{
				int digit = symbol - 48;
				sumOfDigits += digit;
				if (digit % 2 == 0)
				{
					hasEvenDigit = true;
				}
			}
			if ((sumOfDigits % 7 == 0) && hasEvenDigit)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static void Main()
		{
			int end = int.Parse(Console.ReadLine());

			for (int currentNumber = 1; currentNumber <= end; currentNumber++)
			{
				string convertedNumber = currentNumber.ToString();
				if (IsPalindrome(convertedNumber) && DivisibleAndEven(convertedNumber))
				{
					Console.WriteLine(currentNumber);
				}
			}
		}
	}
}
