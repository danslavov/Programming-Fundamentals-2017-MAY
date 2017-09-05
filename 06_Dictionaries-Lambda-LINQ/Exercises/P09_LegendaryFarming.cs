namespace P09_LegendaryFarming
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P09_LegendaryFarming
	{
		public static void Main()
		{
			var legendary = new Dictionary<string, int>();
			legendary["fragments"] = 0;
			legendary["motes"] = 0;
			legendary["shards"] = 0;

			var legendaryObtained = string.Empty;
			var junk = new SortedDictionary<String, int>();
			var noMoreItemsNeeded = false;

			while (!noMoreItemsNeeded)
			{
				var input = Console.ReadLine().Split(' ');
				var quantity = 0;
				var item = String.Empty;

				for (var i = 0; i < input.Length; i += 2)
				{
					if (noMoreItemsNeeded)
					{
						break;
					}

					quantity = int.Parse(input[i]);
					item = input[i + 1].ToLower();

					switch (item)
					{
						case "fragments":
							legendary["fragments"] += quantity;
							break;
						case "motes":
							legendary["motes"] += quantity;
							break;
						case "shards":
							legendary["shards"] += quantity;
							break;

						default:
							if (!junk.ContainsKey(item))
							{
								junk[item] = 0;
							}
							junk[item] += quantity;
							break;
					}

					foreach (var resource in legendary)
					{
						if (resource.Value > 249)
						{
							legendaryObtained = resource.Key;

							switch (resource.Key)
							{
								case "motes":
									legendaryObtained = "Dragonwrath";
									break;
								case "shards":
									legendaryObtained = "Shadowmourne";
									break;
								case "fragments":
									legendaryObtained = "Valanyr";
									break;
							}

							legendary[resource.Key] -= 250;
							noMoreItemsNeeded = true;
							break;
						}
					}
				}
			}

			var sortedLegendary = legendary
				.OrderByDescending(x => x.Value)
				.ThenBy(x => x.Key)
				.ToDictionary(x => x.Key, x => x.Value);

			Print(sortedLegendary, junk, legendaryObtained);
			
		}

		public static void Print
			(Dictionary<string, int> dic1, SortedDictionary<string, int> dic2, string item)
		{
			Console.WriteLine($"{item} obtained!");

			foreach (var resource in dic1)
			{
				Console.WriteLine(resource.Key + ": " + resource.Value);
			}

			foreach (var resource in dic2)
			{
				Console.WriteLine(resource.Key + ": " + resource.Value);
			}
		}
	}
}
