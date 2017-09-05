namespace P05_ShortWordsSorted
{
	using System;
	using System.Linq;

	public class P05_ShortWordsSorted
	{
		public static void Main()
		{
			var text = Console.ReadLine();
			var shortWords = text
				.ToLower()
				.Split(
				new[] { '.', ',', ':', ';', '(', ')', '[', ']', '/', '\'', '"', '!', '?', ' ' },
				StringSplitOptions.RemoveEmptyEntries)
				.Where(x => (x.Length < 5))
				.Distinct()
				.OrderBy(x => x)
				.ToList();

			Console.WriteLine(string.Join(", ", shortWords));
		}
	}
}
