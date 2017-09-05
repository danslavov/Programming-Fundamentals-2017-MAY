namespace P10_SumOfChars
{
	using System;

	public class P10_SumOfChars
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			var sum = 0;

			for (byte i = 0; i < n; i++)
			{
				sum += char.Parse(Console.ReadLine());
			}

			Console.WriteLine("The sum equals: " + sum);
		}
	}
}
