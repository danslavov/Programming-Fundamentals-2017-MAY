namespace P07_AndreyAndBilliard		// 80/100 in Judge
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P07_AndreyAndBilliard
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var inventory = CreateInventory(n);
			var orders = RecieveOrders(inventory);
			SortAndPrintResult(orders);
		}

		public static Dictionary<string, decimal> CreateInventory(int n)
		{
			var inventory = new Dictionary<string, decimal>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split('-');
				var product = input[0];
				var price = decimal.Parse(input[1]);
				inventory[product] = price;
			}
			return inventory;
		}

		public static List<Order> RecieveOrders(Dictionary<string, decimal> inventory)
		{
			var orders = new List<Order>();
			var input = Console.ReadLine().Split(' ', '-', ',');

			while (input[0] != "end")
			{
				var client = input[0];
				var product = input[1];
				var quantity = int.Parse(input[2]);

				if (inventory.ContainsKey(product))
				{
					int i = orders.FindIndex(o => o.Client == client);
					if (i >= 0)
					{
						if (!orders[i].ProductsAndQuantities.ContainsKey(product))
						{
							orders[i].ProductsAndQuantities[product] = 0;
						}
						orders[i].ProductsAndQuantities[product] += quantity;
						orders[i].TotalPrice += quantity * inventory[product];
					}
					else
					{
						orders.Add(new Order
						{
							Client = client,
							ProductsAndQuantities = new Dictionary<string, int>()
							{
								{ product, quantity }
							},
							TotalPrice = quantity * inventory[product]
						});
					}
				}
				input = Console.ReadLine().Split(' ', '-', ',');
			}
			return orders;
		}

		public static void SortAndPrintResult(List<Order> orders)
		{
			var totalBill = 0M;

			foreach (var order in orders.OrderBy(o => o.Client))
			{
				totalBill += order.TotalPrice;
				Console.WriteLine($"{order.Client}");
				foreach (var product in order.ProductsAndQuantities)
				{
					Console.WriteLine($"-- {product.Key} - {product.Value}");
				}
				Console.WriteLine($"Bill: {order.TotalPrice:F2}");
			}
			Console.WriteLine($"Total bill: {totalBill:F2}");
		}
	}

	public class Order
	{
		public string Client { get; set; }
		public Dictionary<string, int> ProductsAndQuantities { get; set; }
		public decimal TotalPrice { get; set; }
	}
}
