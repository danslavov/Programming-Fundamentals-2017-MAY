namespace P09_MakeWord
{
	using System;

	public class P09_MakeWord
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			var word = string.Empty;

			for (byte i = 0; i < n; i++)
			{
				word += Console.ReadLine();
			}

			Console.WriteLine("The word is: " + word);
		}
	}
}
