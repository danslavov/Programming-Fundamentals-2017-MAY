namespace P10_СръбскоUnleashed
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P10_СръбскоUnleashed
	{
		public static void Main()
		{
			var data = new Dictionary<string, Dictionary<string, int>>();

			while (true)
			{
				var input = Console.ReadLine();

				if (input == "End")
				{
					break;
				}

				if (!input.Contains(" @"))
				{
					continue;
				}

				var splitInput = input.Split('@').ToList();
				var name = splitInput[0].Trim();
				var venueAndTickets = splitInput[1].Split(' ').ToList();

				var validInput1 = int.TryParse(venueAndTickets[venueAndTickets.Count - 1], out int ticketCount);
				if (!validInput1)
				{
					continue;
				}

				var validInput2 = int.TryParse(venueAndTickets[venueAndTickets.Count - 2], out int ticketPrice);
				if (!validInput2)
				{
					continue;
				}

				var money = ticketCount * ticketPrice;

				venueAndTickets.Remove(venueAndTickets[venueAndTickets.Count - 1]);
				venueAndTickets.Remove(venueAndTickets[venueAndTickets.Count - 1]);
				var venue = String.Join(" ", venueAndTickets);

				if (!data.ContainsKey(venue))
				{
					data[venue] = new Dictionary<string, int>();
				}

				if (!data[venue].ContainsKey(name))
				{
					data[venue][name] = 0;
				}

				data[venue][name] += money;

			}

			var sortedData = new Dictionary<string, Dictionary<string, int>>();

			foreach (var venue in data)
			{
				sortedData[venue.Key] = venue.Value
					.OrderByDescending(x => x.Value)
					.ToDictionary(x => x.Key, x => x.Value);
			}

			foreach (var town in sortedData)
			{
				Console.WriteLine(town.Key);

				foreach (var item in town.Value)
				{
					Console.WriteLine($"#  {item.Key} -> {item.Value}");
				}
			}
		}
	}
}
