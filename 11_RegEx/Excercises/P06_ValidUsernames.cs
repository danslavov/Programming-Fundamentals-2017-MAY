namespace P06_ValidUsernames
{
	using System;
	using System.Text.RegularExpressions;

	public class P06_ValidUsernames
	{
		public static void Main()
		{
			FindAndPrintTwoLongest(ExtractUsernames());
		}

		public static void FindAndPrintTwoLongest(MatchCollection usernames)
		{
			
			var first = usernames[0].Value;
			var second = usernames[1].Value;
			var length = first.Length + second.Length;

			for (int i = 2; i < usernames.Count; i++)
			{
				var newSecond = usernames[i].Value;
				var newFirst = usernames[i - 1].Value;
				if (newFirst.Length + newSecond.Length > length)
				{
					first = newFirst;
					second = newSecond;
					length = first.Length + second.Length;
				}
			}
			Console.WriteLine($"{first}\n{second}");
		}

		public static MatchCollection ExtractUsernames()
		{
			var regex = new Regex(
				@"(?:^|(?<=[\s\\\/\(\)]))[A-Za-z]\w{2,24}(?:$|(?=[\s\\\/\(\)]))");
			var input = Console.ReadLine();
			return regex.Matches(input);
		}
	}
}
