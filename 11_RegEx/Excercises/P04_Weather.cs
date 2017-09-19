namespace P04_Weather
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;

	public class P04_Weather
	{
		public static void Main()
		{
			var towns = new List<Town>();			
			var input = Console.ReadLine();

			while (input != "end")
			{
				AddTown(input, towns);
				input = Console.ReadLine();
			}
			
			SortAndPrintTowns(towns);
		}

		public static void SortAndPrintTowns(List<Town> towns)
		{
			towns = towns.OrderBy(t => t.temperature).ToList();
			towns.ForEach(t => Console.WriteLine(
				$"{t.name} => {t.temperature:F2} => {t.weather}"));
		}

		public static void AddTown(string input, List<Town> towns)
		{
			var regex = new Regex(
				@"(?<name>[A-Z]{2})(?<temperature>\d+\.\d+)(?<weather>[A-Za-z]+)(?=\|)");
			var town = regex.Match(input);
			if (town.Value != "")
			{
				var name = town.Groups["name"].Value;
				var temperature = double.Parse(town.Groups["temperature"].Value);
				var weather = town.Groups["weather"].Value;

				var existingTown = towns.Find(t => t.name == name);
				if (existingTown == null)
				{
					towns.Add(new Town
					{
						name = name,
						temperature = temperature,
						weather = weather
					});
				}
				else
				{
					existingTown.temperature = temperature;
					existingTown.weather = weather;
				}
			}
		}
	}
	
	public class Town
	{
		public string name { get; set; }
		public double temperature { get; set; }
		public string weather { get; set; }
	}
}
