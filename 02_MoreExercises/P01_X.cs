namespace P01_X
{
	using System;

	public class P01_X
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n / 2; i++)
			{
				Console.WriteLine(RepeatStr(' ', i) + "x" +
					RepeatStr(' ', n - 2 * (i + 1)) + "x");
			}

			Console.WriteLine(RepeatStr(' ', n / 2) + "x");

			for (int i = n / 2 - 1; i >= 0; i--)
			{
				Console.WriteLine(RepeatStr(' ', i) + "x" +
					RepeatStr(' ', n - 2 * (i + 1)) + "x");
			}
		}

		public static string RepeatStr(char symbol, int count)
		{
			var output = String.Empty;
			for (int i = 0; i < count; i++)
			{
				output += symbol;
			}
			return output;
		}
	}
}
