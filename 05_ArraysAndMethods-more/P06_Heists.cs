namespace P06_Heists
{
	using System;

	public class P06_Heists
	{
		public static void Main()
		{
			var jewelsAndGoldPrice = Console.ReadLine().Split();
			var jewelPrice = int.Parse(jewelsAndGoldPrice[0]);
			var goldPrice = int.Parse(jewelsAndGoldPrice[1]);

			var jewelCount = 0;
			var goldCount = 0;
			var expenses = 0;

			while (true)
			{
				var heist = Console.ReadLine().Split();
				if (!(heist[0] == "Jail" && heist[1] == "Time"))
				{
					expenses += int.Parse(heist[1]);

					foreach (var symbol in heist[0])
					{
						if (symbol == '%')
						{
							jewelCount++;
						}
						if (symbol == '$')
						{
							goldCount++;
						}
					}
				}

				else
				{
					break;
				}
			}

			var earnings = jewelPrice * jewelCount + goldPrice * goldCount;
			var profit = earnings - expenses;

			if (profit >= 0)
			{
				Console.WriteLine($"Heists will continue. Total earnings: {profit}.");
			}
			else
			{
				Console.WriteLine($"Have to find another job. Lost: {Math.Abs(profit)}.");
			}
		}
	}
}
