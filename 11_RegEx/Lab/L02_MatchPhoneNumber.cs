namespace P02_MatchPhoneNumber
{
	using System;
	using System.Text.RegularExpressions;

	public class L02_MatchPhoneNumber
	{
		public static void Main(string[] args)
		{
			var regex = new Regex(@"(?:\s|^)(\+359(\s|\-)2\2\d{3}\2\d{4}\b)");
			var input = Console.ReadLine();
			var matches = regex.Matches(input);
			var result = new string[matches.Count];
			for (int i = 0; i < result.Length; i++)
			{
				result[i] = matches[i].Groups[0].Value.Trim();
			}
			Console.WriteLine(string.Join(", ", result));
		}
	}
}
