namespace P02_RandomizeWords
{
	using System;

	public class P02_RandomizeWords
	{
		public static void Main()
		{
			var words = Console.ReadLine().Split(' ');
			var rnd = new Random();

			for (var i = 0; i < words.Length; i++)
			{
				var randomIndex = rnd.Next(0, words.Length);
				var tempWord = words[randomIndex];
				words[randomIndex] = words[i];
				words[i] = tempWord;
			}

			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}
