namespace P07_SalesReport
{
	using System;
	using System.Collections.Generic;

	public class P07_SalesReport
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			var listOfSales = new List<Sale>();

			for (var i = 0; i < n; i++)
			{
				var currentSale = EnterSale(Console.ReadLine());
				listOfSales.Add(currentSale);
			}

			var dictOfSales = new SortedDictionary<string, double>();

			foreach (var item in listOfSales)
			{
				if (!dictOfSales.ContainsKey(item.Town))
				{
					dictOfSales[item.Town] = 0.0;
				}
				dictOfSales[item.Town] += item.Price * item.Quantity;
			}

			foreach (var town in dictOfSales)
			{
				Console.WriteLine($"{town.Key} -> {town.Value:F2}");
			}
		}

		public static Sale EnterSale(string input)
		{
			var data = input.Split(' ');
			return new Sale
			{
				Town = data[0],
				Product = data[1],
				Price = double.Parse(data[2]),
				Quantity = double.Parse(data[3])
			};
		}
	}
}
