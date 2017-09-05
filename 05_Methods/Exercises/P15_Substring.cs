namespace P15_Substring
{
	using System;

	public class P15_Substring
	{
		public static void Main()
		{
			string text = Console.ReadLine();
			int jump = int.Parse(Console.ReadLine());

			//const char Search = 'р';
			bool hasMatch = false;

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == 'p')
				{
					hasMatch = true;

					int endIndex = jump;

					if (endIndex > text.Length - i - 1)
					{
						endIndex = text.Length - i - 1;
					}

					string matchedString = text.Substring(i, endIndex + 1);
					Console.WriteLine(matchedString);
					i += jump;
				}
			}

			if (!hasMatch)
			{
				Console.WriteLine("no");
			}
		}
	}
}
