namespace P11_StringConcatenation
{
	using System;

	public class P11_StringConcatenation
	{
		public static void Main()
		{
			var delimiter = char.Parse(Console.ReadLine());
			var evenOrOdd = Console.ReadLine();
			var n = byte.Parse(Console.ReadLine());
			var result = string.Empty;

			for (byte i = 1; i <= n; i++)
			{
				var word = Console.ReadLine();
				var conditionIsMet = (evenOrOdd == "odd" && i % 2 != 0)
					|| (evenOrOdd == "even" && i % 2 == 0);

				if (conditionIsMet)
				{
					result += (word + delimiter);
				}
			}

			result = result.Remove(result.Length - 1);
			Console.WriteLine(result);
		}
	}
}
