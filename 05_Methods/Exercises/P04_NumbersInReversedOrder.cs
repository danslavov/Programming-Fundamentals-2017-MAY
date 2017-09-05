namespace P04_NumbersInReversedOrder
{
	using System;

	public class P04_NumbersInReversedOrder
	{
		public static void ReverseString(string text)
		{
			string reversedText = "";
			foreach (char symbol in text)
			{
				reversedText = symbol + reversedText;
			}
			Console.WriteLine(reversedText);
		}

		public static void Main()
		{
			string number = Console.ReadLine();
			ReverseString(number);
		}
	}
}
