namespace P04_Largest3Numbers
{
	using System;
	using System.Linq;

	public class P04_Largest3Numbers
	{
		public static void Main()
		{
			Console.ReadLine()
				.Split(' ')
				.Select(double.Parse)
				.OrderByDescending(x => x)
				.Take(3)
				.ToList()
				.ForEach(Console.WriteLine);
		}
	}
}
