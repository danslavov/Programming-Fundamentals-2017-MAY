namespace P09_MelrahShake
{
	using System;

	public class P09_MelrahShake
	{
		public static void Main()
		{
			var text = Console.ReadLine();
			var pattern = Console.ReadLine();
			if (pattern.Length > 0)
			{
				text = Shake(text, pattern);
			}
			Console.WriteLine("No shake.\n{0}", text);
		}

		public static string Shake(string text, string pattern)
		{
			var previousText = text;
			while (true)
			{
				var endIndex = text.LastIndexOf(pattern);
				if (endIndex < 0)
				{
					return previousText;
				}
				text = text.Remove(endIndex, pattern.Length);
				var frontIndex = text.IndexOf(pattern);
				if (frontIndex < 0)
				{
					return previousText;
				}
				text = text.Remove(frontIndex, pattern.Length);
				Console.WriteLine("Shaked it.");
				previousText = text;
				pattern = pattern.Remove(pattern.Length / 2, 1);
				if (pattern.Length < 1)
				{
					return text;
				}
			}
		}
	}
}
