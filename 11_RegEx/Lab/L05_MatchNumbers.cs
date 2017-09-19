namespace L05_MatchNumbers
{
	using System;
	using System.Text.RegularExpressions;

	public class L05_MatchNumbers
	{
		public static void Main(string[] args)
		{
			var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
			var input = Console.ReadLine();
			var result = Regex.Matches(input, pattern);
			for (var i = 0; i < result.Count; i++)
			{
				Console.Write(result[i]);
				if (i < result.Count - 1)
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
}
