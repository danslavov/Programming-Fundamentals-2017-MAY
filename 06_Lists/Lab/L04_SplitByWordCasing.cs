namespace P04_SplitByWordCasing
{
	using System;
	using System.Collections.Generic;

	public class P04_SplitByWordCasing
	{
		public static void Main()
		{
			var inputText = Console.ReadLine()
				.Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' ' },
				StringSplitOptions.RemoveEmptyEntries);
			var lowerCase = new List<string>();
			var upperCase = new List<string>();
			var mixedCase = new List<string>();

			foreach (string word in inputText)
			{
				int lowercaseCount = 0;
				int uppercaseCount = 0;
				foreach (var letter in word)
				{
					if (letter > 96 && letter < 123)
					{
						lowercaseCount++;
					}
					if (letter > 64 && letter < 91)
					{
						uppercaseCount++;
					}
				}
				if (lowercaseCount == word.Length)
				{
					lowerCase.Add(word);
				}
				else if (uppercaseCount == word.Length)
				{
					upperCase.Add(word);
				}
				else
				{
					mixedCase.Add(word);
				}
			}
			var printLowerCase = string.Join(", ", lowerCase);
			var printUpperCase = string.Join(", ", upperCase);
			var printMixedCase = string.Join(", ", mixedCase);
			Console.WriteLine($"Lower-case: {printLowerCase}\n" +
				$"Mixed-case: {printMixedCase}\n" +
				$"Upper-case: {printUpperCase}");
		}
	}
}