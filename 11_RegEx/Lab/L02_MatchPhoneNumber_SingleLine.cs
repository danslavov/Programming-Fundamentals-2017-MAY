namespace P02_MatchPhoneNumber
{
	using System;
	using System.Text.RegularExpressions;
	using System.Linq;

	public class L02_MatchPhoneNumber_SingleLine
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(string.Join(", ", Regex.Matches(
				Console.ReadLine(), @"(?:\s|^)(\+359(\s|\-)2\2\d{3}\2\d{4}\b)")
				.Cast<Match>()
				.Select(a => a.Groups[0].Value.Trim())
				.ToArray()));
		}
	}
}
