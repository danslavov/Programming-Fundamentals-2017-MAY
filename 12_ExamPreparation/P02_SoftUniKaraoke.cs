namespace P02_SoftUniKaraoke
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P02_SoftUniKaraoke
	{
		public static void Main()
		{
			var result = new Dictionary<string, List<string>>();
			var participants = Console.ReadLine()
				.Split(',')
				.Select(p => p.Trim())
				.ToList();
			var songs = Console.ReadLine()
				.Split(',')
				.Select(p => p.Trim())
				.ToList();
			var input = Console.ReadLine();
			while (input != "dawn")
			{
				PopulateResult(result, input, participants, songs);
				input = Console.ReadLine();
			}
			SortAndPrintResult(result);
		}

		public static void SortAndPrintResult(Dictionary<string, List<string>> result)
		{
			if (result.Any())
			{
				foreach (var participant in result
					.OrderByDescending(p => p.Value.Count)
					.ThenBy(p => p.Key))
				{
					Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
					foreach (var award in participant.Value.OrderBy(a => a))
					{
						Console.WriteLine("--" + award);
					}
				}
			}
			else
			{
				Console.WriteLine("No awards");
			}
		}

		public static void PopulateResult(Dictionary<string, List<string>> result,
			string input, List<string> participants, List<string> songs)
		{
			var performanceData = input
				.Split(',')
				.Select(p => p.Trim())
				.ToArray();
			var participant = performanceData[0];
			var song = performanceData[1];
			var award = performanceData[2];
			if (participants.Contains(participant) && songs.Contains(song))
			{
				AddParticipant(result, participant, award);
			}
		}

		public static void AddParticipant(Dictionary<string, List<string>> result,
			string participant, string award)
		{
			if (!result.ContainsKey(participant))
			{
				result[participant] = new List<string>();
			}
			if (!result[participant].Contains(award))   // add only unique awards
			{
				result[participant].Add(award);
			}
		}
	}
}
