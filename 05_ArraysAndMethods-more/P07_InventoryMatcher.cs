namespace P07_InventoryMatcher
{
	using System;
	using System.Linq;

	public class P07_InventoryMatcher
	{
		public static void Main()
		{
			var name = Console.ReadLine().Split();
			var quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
			var price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
			var product = Console.ReadLine();

			while (product != "done")
			{
				var currentPrice = price[Array.IndexOf(name, product)];
				var currentQuantity = quantity[Array.IndexOf(name, product)];
				Console.WriteLine($"{product} costs: {currentPrice}; " +
					$"Available quantity: {currentQuantity}");

				product = Console.ReadLine();
			}
		}
	}
}
