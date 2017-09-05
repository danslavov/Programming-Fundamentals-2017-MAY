namespace P15_NeighbourWars
{
	using System;

	public class P15_NeighbourWars
	{
		public static void Main()
		{
			var healthPesho = 100;
			var healthGosho = 100;
			var round = 1;
			var damageGosho = int.Parse(Console.ReadLine());
			var damagePesho = int.Parse(Console.ReadLine());

			while (true)
			{
				healthGosho -= damageGosho;

				if (healthGosho <= 0)
				{
					Console.WriteLine($"Pesho won in {round}th round.");
					return;
				}

				Console.WriteLine($"Pesho used Roundhouse kick and reduced " +
					$"Gosho to {healthGosho} health.");

				if (round % 3 == 0)
				{
					healthGosho += 10;
					healthPesho += 10;
				}

				round++;

				healthPesho -= damagePesho;

				if (healthPesho <= 0)
				{
					Console.WriteLine($"Gosho won in {round}th round.");
					return;
				}

				Console.WriteLine($"Gosho used Thunderous fist and reduced " +
					$"Pesho to {healthPesho} health.");

				if (round % 3 == 0)
				{
					healthGosho += 10;
					healthPesho += 10;
				}

				round++;
			}
		}
	}
}
