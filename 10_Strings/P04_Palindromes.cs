namespace P04_Palindromes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P04_Palindromes
	{
		public static void Main()
		{
			var text = Console.ReadLine()
				.Split(new char[] { ' ', ',', '.', '?', '!' },
				StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			var palindromes = new List<string>();
			FindPalindromes(text, palindromes);
			Console.WriteLine(string.Join(", ", palindromes.OrderBy(word => word)));
		}

		public static void FindPalindromes(string[] text, List<string> palindromes)
		{
			foreach (var word in text)
			{
				var isPalindrome = true;
				for (int i = 0; i < word.Length / 2; i++)
				{
					if (word[i] != word[word.Length - 1 - i])
					{
						isPalindrome = false;
						break;
					}
				}
				if(isPalindrome && !palindromes.Contains(word))
				{
					palindromes.Add(word);
				}
			}
		}
	}
}
