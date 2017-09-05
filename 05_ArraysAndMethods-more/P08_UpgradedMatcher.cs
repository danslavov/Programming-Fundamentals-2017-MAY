namespace P08_UpgradedMatcher
{
	using System;
	using System.Linq;

	public class P08_UpgradedMatcher
	{
		public static void Main()
		{
			var names = Console.ReadLine().Split();
			var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
			var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
			var input = Console.ReadLine().Split();
			var quantityAvailabe = 0L;
			
			while (input[0] != "done")
			{
				var name = input[0];
				var quantityNeeded = long.Parse(input[1]);
				var price = prices[Array.IndexOf(names, name)];

				try
				{
					quantityAvailabe = quantities[Array.IndexOf(names, name)];
				}
				catch (Exception)
				{
					quantityAvailabe = 0L;
				}

				if (quantityAvailabe - quantityNeeded >= 0)
				{
					var totalPrice = price * quantityNeeded;
					Console.WriteLine($"{name} x {quantityNeeded} costs {totalPrice:F2}");
					quantities[Array.IndexOf(names, name)] -= quantityNeeded;
				}
				else
				{
					Console.WriteLine($"We do not have enough {name}");
				}

				input = Console.ReadLine().Split();
			}
		}
	}
}