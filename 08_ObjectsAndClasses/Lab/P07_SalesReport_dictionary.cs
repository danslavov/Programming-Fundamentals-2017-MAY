namespace P07_SalesReport
{
	using System;
	using System.Collections.Generic;

	public class P07_SalesReport_dictionary
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			var dictOfSales = new SortedDictionary<string, double>();

			for (var i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				var town = input[0];
				var money = double.Parse(input[2]) * double.Parse(input[3]);

				if (!dictOfSales.ContainsKey(town))
				{
					dictOfSales[town] = 0.0;
				}
				dictOfSales[town] += money;
			}

			foreach (var town in dictOfSales)
			{
				Console.WriteLine($"{town.Key} -> {town.Value:F2}");
			}
		}
	}
}
