namespace P11_DragonArmy
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P11_DragonArmy
	{
		public static void Main()
		{
			var data = new Dictionary<string, Dictionary<string, int[]>>();  // inner dict can be SortedDictionary to avoid manual sorting with SortByDragonName()
			var n = int.Parse(Console.ReadLine());

			for (var i = 0; i < n; i++)
			{
				data = PopulateData(data, Console.ReadLine().Split(' ').ToArray());
			}

			data = SortByDragonName(data);

			// print result
			foreach (var dragonType in data)
			{
				Console.WriteLine(dragonType.Key + "::" + GetAverageStats(dragonType.Value));

				foreach (var dragonName in dragonType.Value)
				{
					Console.WriteLine($"-{dragonName.Key} -> " +
						$"damage: {dragonName.Value[0]}, health: {dragonName.Value[1]}, " +
						$"armor: {dragonName.Value[2]}");
				}
			}
		}

		public static Dictionary<string, Dictionary<string, int[]>>
			PopulateData(Dictionary<string, Dictionary<string, int[]>> data, string[] input)
		{
			var type = input[0];
			var name = input[1];
			var stats = new int[3];

			for (var j = 0; j < 3; j++)
			{
				try
				{
					stats[j] = int.Parse(input[j + 2]);
				}
				// if the stat is missing, e.g. "null"
				catch (Exception)
				{
					// assign default values
					switch (j)
					{
						case 0:
							stats[j] = 45;
							break;
						case 1:
							stats[j] = 250;
							break;
						case 2:
							stats[j] = 10;
							break;
					}
				}
			}

			if (!data.ContainsKey(type))
			{
				data[type] = new Dictionary<string, int[]>();
			}

			data[type][name] = stats;
			return data;
		}

		public static Dictionary<string, Dictionary<string, int[]>>
			SortByDragonName(Dictionary<string, Dictionary<string, int[]>> dict)
		{
			var sortDict = new Dictionary<string, Dictionary<string, int[]>>();

			foreach (var dragonType in dict)
			{
				var dragonName = dragonType.Value
					.OrderBy(x => x.Key)
					.ToDictionary(y => y.Key, y => y.Value);
				sortDict[dragonType.Key] = dragonName;
			}

			return sortDict;
		}

		public static string
			GetAverageStats(Dictionary<string, int[]> dict)     // foreach (var item in dict) { var avgDamage, etc. = item.Value.Values.Average(x => x[0 to 2]); }
		{
			var avgDamage = 0.0;
			var avgHealth = 0.0;
			var avgArmor = 0.0;

			foreach (var name in dict)
			{
				avgDamage += name.Value[0];
				avgHealth += name.Value[1];
				avgArmor += name.Value[2];
			}

			avgDamage /= dict.Count();
			avgHealth /= dict.Count();
			avgArmor /= dict.Count();

			return string.Format("({0:F2}/{1:F2}/{2:F2})", avgDamage, avgHealth, avgArmor);
		}
	}
}