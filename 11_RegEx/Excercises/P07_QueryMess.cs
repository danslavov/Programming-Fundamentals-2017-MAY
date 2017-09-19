namespace P07_QueryMess
{
	using System;
	using System.Text.RegularExpressions;
	using System.Collections.Generic;

	public class P07_QueryMess
	{
		public static void Main()
		{
			var input = Console.ReadLine();
			while (input != "END")
			{
				var queries = ExtractQueries(input);
				var result = ArrangePairs(queries);
				PrintResult(result);
				input = Console.ReadLine();
			}
		}

		public static void PrintResult(Dictionary<string, List<string>> result)
		{
			foreach (var kvp in result)
			{
				if (kvp.Key != "")
				{
					Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
				}
			}
			Console.WriteLine();
		}

		public static Dictionary<string, List<string>> ArrangePairs(string[] queries)
		{
			var pairs = new Dictionary<string, List<string>>();
			foreach (var q in queries)
			{
				var key = Regex.Match(q, @"(^|(?<=\?)).*(?=\=)").Value.Trim();
				var value = Regex.Match(q, @"(?<=\=).*").Value.Trim();
				if (!pairs.ContainsKey(key))
				{
					pairs[key] = new List<string>();
				}
				pairs[key].Add(value);
			}
			return pairs;
		}

		public static string[] ExtractQueries(string input)
		{
			input = Regex.Replace(input, @"\+|(%20)", " ");
			input = Regex.Replace(input, @"\s{2,}", " ");
			return Regex.Split(input, @"[&?]");
		}
	}
}
