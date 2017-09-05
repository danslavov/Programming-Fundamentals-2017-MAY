namespace P03_UnicodeCharacters
{
	using System;
	using System.Linq;

	public class P03_UnicodeCharacters
	{
		public static void Main()
		{
			var input = Console.ReadLine();
			var result = input.Select(t => string.Format("\\u{0:X4}", Convert.ToUInt16(t))).ToList();
			Console.WriteLine(string.Join("", result).ToLower());
		}
	}
}
