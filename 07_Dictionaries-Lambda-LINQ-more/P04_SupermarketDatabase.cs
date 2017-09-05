namespace P04_SupermarketDatabase
{
	using System;
	using System.Collections.Generic;

	public class P04_SupermarketDatabase
	{
		public static void Main()
		{
			var names = new List<string>();
			var prices = new List<double>();
			var quantities = new List<int>();

			var input = Console.ReadLine().Split();

			while (input[0] != "stocked")
			{
				var name = input[0];
				var price = double.Parse(input[1]);
				var quantity = int.Parse(input[2]);

				if (!names.Contains(name))
				{
					names.Add(name);
					prices.Add(price);
					quantities.Add(quantity);
				}
				else
				{
					var index = names.IndexOf(name);
					prices[index] = price;
					quantities[index] += quantity;
				}

				input = Console.ReadLine().Split();
			}

			PrintInventory(names, prices, quantities);
		}

		public static void PrintInventory(
			List<string> products, List<double> prices, List<int> quantities)
		{
			var GrandTotal = 0.0;

			for (int i = 0; i < products.Count; i++)
			{
				var product = products[i];
				var price = prices[i];
				var quantity = quantities[i];
				var totalPrice = price * quantity;
				Console.WriteLine(
					$"{product}: ${price:F2} * {quantity} = ${totalPrice:F2}");
				GrandTotal += totalPrice;
			}

			Console.WriteLine("------------------------------");
			Console.WriteLine($"Grand Total: ${GrandTotal:F2}");
		}
	}
}
