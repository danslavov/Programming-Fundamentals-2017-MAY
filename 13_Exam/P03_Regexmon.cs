namespace P03_Regexmon
{
	using System;

	public class P03_Regexmon
	{
		public static void Main()
		{
			var text = Console.ReadLine();
			var index = 0;
			while (index < text.Length)
			{
				FirstSearch(text, ref index);
				if (index >= text.Length)
					return;
				SecondSearch(text, ref index);
			}
		}

		public static void SecondSearch(string text, ref int index)
		{
			var result = "";
			for (int i = index; i < text.Length; i++)
			{
				if (i == text.Length - 1)
				{
					index = i + 1;
				}
				if (char.IsLetter(text[i]) || (text[i] == '-'))
				{
					result += text[i];
				}
				else
				{
					if (HasMatch(ref result))
					{
						Console.WriteLine(result);
						index = i;
						return;
					}
					else
					{
						result = "";
					}
				}
			}
			if (HasMatch(ref result))
			{
				Console.WriteLine(result);
			}
		}

		public static bool HasMatch(ref string result)
		{
			var splitResult = result.Split("-".ToCharArray(),
				StringSplitOptions.RemoveEmptyEntries);
			if (splitResult.Length >= 2)
			{
				for (int i = 1; i < splitResult.Length; i++)
				{
					if (splitResult[i - 1].Length == splitResult[i].Length)
					{
						result = splitResult[i - 1] + "-" + splitResult[i];
						return true;
					}
				}
			}
			return false;
		}

		public static void FirstSearch(string text, ref int index)
		{
			var result = "";
			for (int i = index; i < text.Length; i++)
			{
				if (i == text.Length - 1)
				{
					index = i + 1;
				}
				if (!(char.IsLetter(text[i]) || text[i] == '-'))
				{
					result += text[i];
				}
				else
				{
					if (result.Length > 0)
					{
						index = i;
						break;
					}
				}
			}
			if (result.Length > 0)
			{
				Console.WriteLine(result);
			}
		}
	}
}
