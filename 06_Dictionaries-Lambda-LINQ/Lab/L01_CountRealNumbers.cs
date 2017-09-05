namespace P01_CountRealNumbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Program
	{
		public static void Main()
		{
			List<double> input = Console.ReadLine()
				.Split(' ').Select(double.Parse).ToList();
			var dict = new SortedDictionary<double, int>();
			foreach (var item in input)
			{
				if (dict.ContainsKey(item))
				{
					dict[item]++;
				}
				else
				{
					dict[item] = 1;
				}
			}
			foreach (var num in dict.Keys)
			{
				Console.WriteLine(num + "->" + dict[num]);
			}
		}
	}
}
