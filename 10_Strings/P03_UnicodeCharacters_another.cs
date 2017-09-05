namespace P03_UnicodeCharacters
{
	using System;

	public class P03_UnicodeCharacters_another
	{
		public static void Main()
		{
			var input = Console.ReadLine();
			foreach (var symbol in input)
			{
				Console.Write($"\\u{(int)symbol:X4}".ToLower());
			}
			Console.WriteLine();
		}
	}
}
