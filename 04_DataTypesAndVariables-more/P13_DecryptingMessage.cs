namespace P13_DecryptingMessage
{
	using System;

	public class P13_DecryptingMessage
	{
		public static void Main()
		{
			var key = byte.Parse(Console.ReadLine());
			var n = byte.Parse(Console.ReadLine());
			var decryptedWord = String.Empty;

			for (byte i = 0; i < n; i++)
			{
				var ch = char.Parse(Console.ReadLine());
				decryptedWord += (char)(ch + key);
			}

			Console.WriteLine(decryptedWord);
		}
	}
}
