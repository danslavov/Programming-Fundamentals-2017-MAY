namespace L04_MatchDates
{
	using System;
	using System.Text.RegularExpressions;

	public class L04_MatchDates
	{
		public static void Main(string[] args)
		{
			var regex = new Regex(
				@"(?<day>\d{2})(?<sep>\/|\.|\-)(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})");
			var result = regex.Matches(Console.ReadLine());
			foreach (Match date in result)
			{
				Console.WriteLine(
					$"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
			}
			Console.WriteLine();
		}
	}
}
