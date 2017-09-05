namespace P09_CountIntegers
{
	using System;

	public class P09_CountIntegers
	{
		public static void Main()
		{
			var input = 0;
			var count = 0;

			while (true)
			{
				try
				{
					input = int.Parse(Console.ReadLine());
					count++;
				}
				catch (Exception)
				{
					break;
				}
			}
			Console.WriteLine(count);
		}
	}
}
