namespace P03_ImmuneSystem
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P03_ImmuneSystem
	{
		public static void Main()
		{
			var health = int.Parse(Console.ReadLine());
			var initialHealth = health;
			var virusName = Console.ReadLine();
			var defeatedViruses = new List<string>();

			while (virusName != "end")
			{
				var virusStrength = SumLetters(virusName);
				var timeToDefeat = virusStrength * virusName.Length;

				if (defeatedViruses.Contains(virusName))
				{
					timeToDefeat /= 3;
				}

				Console.WriteLine(
					$"Virus {virusName}: {virusStrength} => {timeToDefeat} seconds");
				health -= timeToDefeat;

				if (health > 0)
				{
					PrintStrengthAndTime(health, virusName, timeToDefeat);

					//  immune system regains 20% of its strength:
					health += health * 2 / 10;
					if (health > initialHealth)
					{
						health = initialHealth;
					}
				}
				else
				{
					Console.WriteLine("Immune System Defeated.");
					return;
				}

				defeatedViruses.Add(virusName);
				virusName = Console.ReadLine();
			}

			Console.WriteLine($"Final Health: {health}");
		}

		public static void PrintStrengthAndTime(int health, string virusName, int time)
		{
			var virusDefeatMinutes = time / 60;
			var virusDefeatSeconds = time % 60;
			Console.WriteLine($"{virusName} defeated in " +
				$"{virusDefeatMinutes}m {virusDefeatSeconds}s.");
			Console.WriteLine($"Remaining health: {health}");
		}

		public static int SumLetters(string word)
		{
			var charArray = word.ToCharArray();
			var sum = 0;
			foreach (var symbol in charArray)
			{
				sum += symbol;
			}
			return sum / 3;
		}
	}
}
