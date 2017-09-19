namespace L03_MatchHexadecimalNumbers
{
	using System;
	using System.Text.RegularExpressions;
	using System.Linq;

	public class L03_MatchHexadecimalNumbers
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(string.Join(
				" ", Regex.Matches(Console.ReadLine(), @"\b(?:0x)*[\dA-F]+\b")
				.Cast<Match>()
				.Select(m => m.Value)
				.ToArray()));
		}
	}
}
