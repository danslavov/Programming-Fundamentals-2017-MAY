namespace P03_EnglishNameOfLastDigit
	{
	using System;

	public class P03_EnglishNameOfLastDigit
	{
		public static void LastDigitName(long number)
		{
			long lastDigit = Math.Abs(number) % 10;
			string digitName = "";

			switch (lastDigit)
			{
				case 0:
					digitName = "zero";
					break;
				case 1:
					digitName = "one";
					break;
				case 2:
					digitName = "two";
					break;
				case 3:
					digitName = "three";
					break;
				case 4:
					digitName = "four";
					break;
				case 5:
					digitName = "five";
					break;
				case 6:
					digitName = "six";
					break;
				case 7:
					digitName = "seven";
					break;
				case 8:
					digitName = "eight";
					break;
				case 9:
					digitName = "nine";
					break;
			}
			Console.WriteLine(digitName);
		}

		public static void Main()
		{
			long n = long.Parse(Console.ReadLine());
			LastDigitName(n);
		}
	}
}
