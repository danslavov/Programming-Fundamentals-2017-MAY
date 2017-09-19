namespace P02_ExtractSentencesByKeyword
{
	using System;
	using System.Text.RegularExpressions;
	using System.Linq;

	public class P02_ExtractSentencesByKeyword
	{
		public static void Main(string[] args)
		{
			var keyword = Console.ReadLine();
			var regex = new Regex($@"\b{keyword}\b");
			var input = Console.ReadLine();
			var sentences = Regex
				.Split(input, @"[.!?]")
				.Select(s => s.Trim())
				.ToArray();

			foreach (var s in sentences)
			{
				if (regex.Match(s).Value == keyword)
				{
					Console.WriteLine(s);
				}
			}
		}
	}
}
