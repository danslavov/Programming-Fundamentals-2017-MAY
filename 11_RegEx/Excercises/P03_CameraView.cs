namespace P03_CameraView
{
	using System;
	using System.Text.RegularExpressions;
	using System.Linq;

	public class P03_CameraView
	{
		public static void Main()
		{
			var skipOrTake = Console.ReadLine();
			var charsToSkip = skipOrTake[0] - '0';
			var charsToTake = skipOrTake[2] - '0';
			var text = Console.ReadLine();
			var regex = new Regex(@"(?<=\|<)\w+");
			var matches = regex.Matches(text);

			for (var i = 0; i < matches.Count; i++)
			{				
				var word = matches[i].Value;
				if (charsToSkip < word.Length)
				{
					var result = word.Substring(charsToSkip,
					Math.Min(charsToTake, word.Length - charsToSkip));
					Console.Write(result);
					if (i < matches.Count - 1)
					{
						Console.Write(", ");
					}
				}
			}
			Console.WriteLine();
		}
	}
}
