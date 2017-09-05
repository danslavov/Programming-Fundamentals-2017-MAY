namespace P05_WriteToFile
{
	using System;
	using System.Collections.Generic;
	using System.IO;

	public class P05_WriteToFile
	{
		public static void Main()
		{
			var text = File.ReadAllText("sample_text.txt");
			var punctuation = new char[] { '.', ',', '!', '?', ':' };
			var result = new List<char>();
			for (int i = 0; i < text.Length; i++)
			{
				foreach (var item in punctuation)
				{
					if (!text[i].Equals(item))
					{
						result.Add(text[i]);
					}
				}
			}
			Console.WriteLine(string.Join(", ", result));
		}
	}
}
