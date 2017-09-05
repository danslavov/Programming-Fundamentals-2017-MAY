namespace P07_SalesReport
{
	using System;
	using System.Linq;

	public class P07_SalesReport_Linq
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			var sales = new Sale[n];

			for (var i = 0; i < n; i++)
			{
				sales[i] = EnterSale(Console.ReadLine());
			}

			var towns = sales.Select(x => x.Town).Distinct().OrderBy(y => y);

			foreach (var town in towns)
			{
				var totalMoney = sales
					.Where(x => x.Town == town)
					.Select(y => y.Price * y.Quantity)
					.Sum();

				Console.WriteLine($"{town} -> {totalMoney:F2}");
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
