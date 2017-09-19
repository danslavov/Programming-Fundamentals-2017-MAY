namespace P08_UseYourChainsBuddy
{
	using System;
	using System.Text.RegularExpressions;
	using System.Linq;
	using System.IO;

	public class P08_UseYourChainsBuddy
	{
		public static void Main()
		{
			// workaround the console limit of 256 chars
			Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

			// collect matches between <p> </p> tags
			var input = Console.ReadLine();
			var matches = Regex
				.Matches(input, @"(?<=\<p\>).*?(?=\<\/p\>)")
				.Cast<Match>()
				.Select(m => m.Value)
				.ToArray();

			// replace crazy chars with spaces and shrink multiple spaces to one
			for (int i = 0; i < matches.Length; i++)
			{
				matches[i] = Regex.Replace(matches[i], @"[^a-z0-9]", " ");
				matches[i] = Regex.Replace(matches[i], @"\s{2,}", " ");
			}

			// convert and print all letters (couldn't find a way trough Regex.Replace)
			ConvertAndPrint(matches);

			Console.WriteLine();
		}

		public static void ConvertAndPrint(string[] matches)
		{
			foreach (var m in matches)
			{
				foreach (var letter in m)
				{
					if (letter >= 97 && letter <= 109)
					{
						Console.Write((char)(letter + 13));
					}
					else if (letter >= 110 && letter <= 122)
					{
						Console.Write((char)(letter - 13));
					}
					else
					{
						Console.Write(letter);
					}
				}
			}
		}
	}
}
