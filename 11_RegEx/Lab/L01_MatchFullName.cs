namespace P01_MatchFullName
{
	using System;
	using System.Text.RegularExpressions;

	public class L01_MatchFullName
	{
		public static void Main(string[] args)
		{
			var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
			var regex = new Regex(pattern);
			var input = Console.ReadLine();
			var matches = regex.Matches(input);
			foreach (Match m in matches)
			{
				Console.Write(m.Value + " ");
			}
			Console.WriteLine();
		}
	}
}
