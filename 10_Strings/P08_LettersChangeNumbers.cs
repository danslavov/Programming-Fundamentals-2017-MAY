namespace P08_LettersChangeNumbers
{
	using System;

	public class P08_LettersChangeNumbers
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split(" \t\n".ToCharArray(),
				StringSplitOptions.RemoveEmptyEntries);
			var total = 0M;
			foreach (var item in input)
			{
				total += CalculateResult(item);
			}
			Console.WriteLine("{0:F2}", total);
		}

		public static decimal CalculateResult(string item)
		{
			var result = 0M;
			var number = decimal.Parse(
					item.Substring(1, item.Length - 2));
			var frontLetter = item[0];
			var backLetter = item[item.Length - 1];
			var frontAlphabetPosition = char.ToUpper(frontLetter) - 64;
			var backAlphabetPosition = char.ToUpper(backLetter) - 64;
			if (frontLetter >= 65 && frontLetter <= 90)
			{
				result += number / frontAlphabetPosition;
			}
			else
			{
				result += number * frontAlphabetPosition;
			}
			if (backLetter >= 65 && backLetter <= 90)
			{
				result -= backAlphabetPosition;
			}
			else
			{
				result += backAlphabetPosition;
			}
			return result;
		}
	}
}
