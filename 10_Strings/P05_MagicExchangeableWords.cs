namespace P05_MagicExchangeableWords	// 60/100 in Judge
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P05_MagicExchangeableWords
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var first = input[0];
			var second = input[1];
			if (first.Length > second.Length)
			{
				LongerBecomesSecond(ref first, ref second);
			}
			Console.WriteLine(
				FindIfExchangeable(first, second).ToString().ToLower());
		}

		public static void LongerBecomesSecond(ref string first, ref string second)
		{
			var tmp = second;
			second = first;
			first = tmp;
		}

		public static bool FindIfExchangeable(string first, string second)
		{
			var pairs = new Dictionary<char, char>();
			for (int i = 0; i < first.Length; i++)
			{
				if (pairs.ContainsKey(first[i]))
				{
					if (pairs[first[i]] != second[i])
					{
						return false;
					}
				}
				else
				{
					pairs[first[i]] = second[i];
				}
			}
			foreach (var letter in second)
			{
				if (!pairs.ContainsValue(letter))
					return false;
			}
			return true;
		}
	}
}
