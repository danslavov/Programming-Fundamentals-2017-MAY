namespace P02_AppendLists
{
	using System;
	using System.Collections.Generic;

	public class P02_AppendLists
	{
		public static void Main()
		{
			var inputStrings = Console.ReadLine().Split('|');
			var result = new List<string>();
			Array.Reverse(inputStrings);
			foreach (string token in inputStrings)
			{
				var numbers = token.Split(' ');
				foreach (var num in numbers)
				{
					if (num != "")
					{
						result.Add(num);
					}
				}
			}
			Console.WriteLine(string.Join(" ", result));
		}
	}
}
