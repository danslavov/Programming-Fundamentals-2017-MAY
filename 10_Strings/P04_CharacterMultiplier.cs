namespace P04_CharacterMultiplier
{
	using System;

	public class P04_CharacterMultiplier
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var firstString = input[0];
			var secondString = input[1];
			if (firstString.Length < secondString.Length)
			{
				LongerBecomesFirst(ref firstString, ref secondString);
			}
			Console.WriteLine(
				CalculateAndPrintResult(firstString, secondString));
		}

		public static void LongerBecomesFirst(
			ref string firstString, ref string secondString)
		{
			{
				var temp = firstString;
				firstString = secondString;
				secondString = temp;
			}
		}

		public static int CalculateAndPrintResult(
			string firstString, string secondString)
		{
			var result = 0;
			for (var i = 0; i < firstString.Length; i++)
			{
				var firstStrValue = firstString[i];
				var secondStrValue = 
					(i < secondString.Length) ? (secondString[i]) : 1;
				result += firstStrValue * secondStrValue;
			}
			return result;
		}
	}
}
