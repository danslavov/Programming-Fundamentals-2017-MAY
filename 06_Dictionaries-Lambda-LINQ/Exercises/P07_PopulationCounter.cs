namespace P07_PopulationCounter
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P07_PopulationCounter
	{
		public static void Main()
		{
			var countries = new Dictionary<string, Dictionary<string, long>>();
			var input = Console.ReadLine().Split('|').ToList();

			while (!input.Contains("report"))
			{
				var country = input[1];
				var city = input[0];
				var population = long.Parse(input[2]);

				if (!countries.ContainsKey(country))
				{
					countries[country] = new Dictionary<string, long>();
				}

				countries[country][city] = population;

				input = Console.ReadLine().Split('|').ToList();
			}

			Print(Sorted(countries));
		}

		public static Dictionary<string, Dictionary<string, long>>
			Sorted(Dictionary<string, Dictionary<string, long>> dict)
		{
			var countries = new Dictionary<string, Dictionary<string, long>>();

			foreach (var country in dict)
			{
				var sortedCities = country.Value
					.OrderByDescending(x => x.Value)
					.ToDictionary(x => x.Key, x => x.Value);

				countries[country.Key] = sortedCities;
			}

			countries = countries
				.OrderByDescending(x => x.Value.Sum(y => y.Value))
				.ToDictionary(x => x.Key, x => x.Value);

			return countries;
		}

		public static void Print(Dictionary<string, Dictionary<string, long>> dict)
		{
			foreach (var country in dict)
			{
				var totalPopulation = country.Value.Sum(y => y.Value);
				Console.WriteLine($"{country.Key} (total population: {totalPopulation})");

				foreach (var city in country.Value)
				{
					Console.WriteLine($"=>{city.Key}: {city.Value}");
				}
			}
		}
	}
}
