namespace P02_VaporStore
{
	using System;
	using System.Collections.Generic;

	public class P02_VaporStore
	{
		public static void Main()
		{
			var games = new Dictionary<string, double>
			{
				{ "OutFall 4", 39.99 },
				{ "CS: OG", 15.99 },
				{ "Zplinter Zell", 19.99 },
				{ "Honored 2", 59.99 },
				{"RoverWatch", 29.99},
				{"RoverWatch Origins Edition", 39.99 }
			};

			var startMoney = double.Parse(Console.ReadLine());
			var ballance = startMoney;
			var game = Console.ReadLine();

			while (game != "Game Time")
			{
				if (games.ContainsKey(game))
				{
					if (games[game] <= ballance)
					{
						ballance -= games[game];
						Console.WriteLine("Bought {0}", game);
					}
					else
					{
						Console.WriteLine("Too Expensive");
					}

					if (ballance <= 0)
					{
						Console.WriteLine("Out of money!");
						return;
					}
				}
				else
				{
					Console.WriteLine("Not Found");
				}

				game = Console.ReadLine();
			}

			Console.WriteLine("Total spent: ${0:F2}. " +
				"Remaining: ${1:F2}", (startMoney - ballance), ballance);
		}
	}
}
