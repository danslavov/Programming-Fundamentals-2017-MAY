namespace P06_SquareNumbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P06_SquareNumbers
	{
		public static void Main()
		{
			var input = Console.ReadLine()
				.Split(' ').Select(int.Parse).ToList();
			var result = new List<int>();
			foreach (var num in input)
			{
				if (num >= 0)
				{
					result.Add(num);
				}
			}
			result.Reverse();

			if (result.Any())
			{
				foreach (var num in result)
				{
					Console.Write(num + " ");
				}
			}
			else
			{
				Console.WriteLine("empty");
			}
			Console.WriteLine();
		}
	}
}