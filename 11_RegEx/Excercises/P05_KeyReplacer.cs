namespace P05_KeyReplacer
{
	using System;
	using System.Text.RegularExpressions;

	public class P05_KeyReplacer
	{
		public static void Main()
		{
			var key = Console.ReadLine();
			var start = Regex.Match(key, @"^[A-Za-z]+(?=[|<\\])").Value;
			var end = Regex.Match(key, @"(?<=[|<\\])[A-Za-z]+$").Value;
			var text = Console.ReadLine();
			var words = Regex.Matches(text, $@"(?<={start}).*?(?={end})");
			var resultIsEmpty = true;

			foreach (Match w in words)
			{
				if (w.Value != "")
				{
					resultIsEmpty = false;
					Console.Write(w.Value);
				}
			}
			if (resultIsEmpty)
			{
				Console.Write("Empty result");
			} 
			Console.WriteLine();
		}
	}
}
