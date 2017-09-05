namespace P02_CountSubstringOccurrences
{
	using System;

	public class P02_CountSubstringOccurrences
	{
		public static void Main()
		{
			var text = Console.ReadLine().ToLower();
			var substring = Console.ReadLine().ToLower();
			var count = 0;
			var fromIndex = 0;
			while (true)
			{
				var foundIndex = text.IndexOf(substring, fromIndex);
				if (foundIndex >= 0)
				{
					fromIndex = foundIndex + 1;
					count++;
				}
				else
					break;
			}
			Console.WriteLine(count);
		}
	}
}
