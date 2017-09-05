namespace P09_TeamworkProjects
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Team
	{
		public string Name { get; set; }
		public List<string> Members { get; set; }
	}

	public class P09_TeamworkProjects
	{
		public static void Main()
		{
			var teamList = new List<Team>();
			var n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				CreateTeam(teamList);
			}
			var input = Console.ReadLine();
			while (input != "end of assignment")
			{
				PopulateTeam(input, teamList);
				input = Console.ReadLine();
			}
			var teamsToDisband = DisbandTeams(teamList);	// get list of teams to disband (to print it later) and remove them from the main list altogether
			SortAndPrintResult(teamList);
			Console.WriteLine("Teams to disband:\n" +
						String.Join("\n", teamsToDisband.OrderBy(name => name)));
		}

		public static void CreateTeam(List<Team> teamList)
		{
			var creatorAndName = Console.ReadLine().Split('-');
			var creator = creatorAndName[0];
			var name = creatorAndName[1];
			var existingTeam = teamList.FindIndex(t => t.Name == name);
			var existingUser = teamList.FindIndex(t => t.Members.Contains(creator));
			if (existingTeam < 0 && existingUser < 0)
			{
				teamList.Add(
					new Team
					{
						Name = name,
						Members = new List<string>() { creator }
					});
				Console.WriteLine($"Team {name} has been created by {creator}!");
			}
			
			//	If user tries to create a team more than once:
			else if (existingTeam >= 0)
			{
				Console.WriteLine($"Team {name} was already created!");
			}

			//	If creator of a team tries to create another team:
			else if (existingUser >= 0)
			{
				Console.WriteLine($"{creator} cannot create another team!");
			}
		}

		public static void PopulateTeam(string input, List<Team> teamList)
		{
			var userAndTeam = input.Split(new char[] { '-', '>' },
				StringSplitOptions.RemoveEmptyEntries);
			var member = userAndTeam[0];
			var name = userAndTeam[1];
			var existingTeam = teamList.FindIndex(t => t.Name == name);
			var existingUser = teamList.FindIndex(t => t.Members.Contains(member));
			if (existingTeam >= 0 && existingUser < 0)
			{
				teamList[existingTeam].Members.Add(member);
			}
			
			//	If user tries to join currently non-existing team:
			else if (existingTeam < 0)
			{
				Console.WriteLine($"Team {name} does not exist!");
			}

			//	If a member of a team tries to join (another?) team:
			else if (existingUser >= 0)
			{
				Console.WriteLine($"Member {member} cannot join team {name}!");
			}
		}

		public static List<string> DisbandTeams(List<Team> teamList)
		{
			var teamsToDisband = new List<string>();
			for (int i = 0; i < teamList.Count; i++)
			{
				if (teamList[i].Members.Count < 2)
				{
					teamsToDisband.Add(teamList[i].Name);
					teamList.Remove(teamList[i]);
					i--;									// to continue from the correct position after removing a team
				}
			}
			return teamsToDisband;
		}

		public static void SortAndPrintResult(List<Team> teamList)
		{
			foreach (var team in teamList
				.OrderByDescending(t => t.Members.Count)
				.ThenBy(t => t.Name))
			{
				Console.WriteLine(team.Name);

				//	print creator:
				Console.WriteLine("- " + team.Members[0]);

				//	print other members:
				var sortedMembers = team.Members
					.Skip(1)
					.OrderBy(member => member)
					.ToList();
				foreach (var member in sortedMembers)
				{
					Console.WriteLine("-- " + member);
				}
			}
		}
	}
}
