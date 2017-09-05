namespace P05_WordInPlural
{
	using System;

	public class P05_WordInPlural
	{
		public static void Main()
		{
			var word = Console.ReadLine();
			var pluralWord = String.Empty;

			var otherEndings = word.EndsWith("o") || word.EndsWith("ch") ||
				word.EndsWith("sh") || word.EndsWith("x") ||
				word.EndsWith("z") || word.EndsWith("s");

			if (word.EndsWith("y"))
			{
				pluralWord = word.Remove(word.Length - 1);
				pluralWord += "ies";
			}
			else if (otherEndings)
			{
				pluralWord = word + "es";
			}
			else
			{
				pluralWord = word + "s";
			}

			Console.WriteLine(pluralWord);
		}
	}
}
