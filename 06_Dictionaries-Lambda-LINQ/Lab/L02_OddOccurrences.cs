namespace P02_OddOccurrences
{
	using System;
	using System.Collections.Generic;

	public class P02_OddOccurrences
	{
		public static void Main()
		{
			var input = Console.ReadLine().ToLower().Split();

			var words = new Dictionary<string, int>();
			foreach (var word in input)
			{
				if (!words.ContainsKey(word))
				{
					words[word] = 0;
				}
				words[word]++;
			}

			var resultList = new List<string>();

			foreach (var word in words)
			{
				if (word.Value % 2 != 0)
				{
					resultList.Add(word.Key);
				}
			}

			Console.WriteLine(string.Join(", ", resultList));
		}
	}
}
