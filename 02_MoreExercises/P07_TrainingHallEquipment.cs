namespace P07_TrainingHallEquipment
{
	using System;

	public class P07_TrainingHallEquipment
	{
		public static void Main()
		{
			var budget = double.Parse(Console.ReadLine());
			var n = int.Parse(Console.ReadLine());
			var subtotal = 0.0;

			for (int i = 0; i < n; i++)
			{
				var name = Console.ReadLine();
				var price = double.Parse(Console.ReadLine());
				var count = int.Parse(Console.ReadLine());

				Console.WriteLine("Adding {0} {1} to cart.",
					count, (count > 1) ? name + "s" : name);

				price *= count;
				subtotal += price;
			}

			budget -= subtotal;

			if (budget >= 0)
			{
				Console.WriteLine("Subtotal: ${0:F2}\nMoney left: ${1:F2}",
					subtotal, budget);
			}
			else
			{
				Console.WriteLine("Subtotal: ${0:F2}\n" +
					"Not enough. We need ${1:F2} more.",
					subtotal, Math.Abs(budget));
			}
		}
	}
}
