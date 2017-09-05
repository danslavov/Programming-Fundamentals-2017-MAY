namespace P01_SweetDessert
{
	using System;

	public class P01_SweetDessert
	{
		public static void Main()
		{
			var cashAvailable = double.Parse(Console.ReadLine());
			var guestCount = int.Parse(Console.ReadLine());
			var bananaPrice = double.Parse(Console.ReadLine());
			var eggyPrice = double.Parse(Console.ReadLine());
			var berryPrice = double.Parse(Console.ReadLine());
			var dessertPrice = 2 * bananaPrice + 4 * eggyPrice + berryPrice / 5;
			var dessertCountNeeded = guestCount / 6;
			if (guestCount % 6 != 0)
			{
				dessertCountNeeded++;
			}
			CalculateAndPrintResult(
				cashAvailable, dessertPrice, dessertCountNeeded);
		}

		public static void CalculateAndPrintResult(
			double cashAvailable, double dessertPrice, int dessertCountNeeded)
		{
			var cashNeeded = dessertPrice * dessertCountNeeded;
			var diff = cashAvailable - cashNeeded;
			if (diff >= 0)
			{
				Console.WriteLine($"Ivancho has enough money - " +
					$"it would cost {cashNeeded:F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivancho will have to withdraw money - " +
					$"he will need {Math.Abs(diff):F2}lv more.");
			}
		}
	}
}
