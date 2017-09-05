namespace P08_LogsAggregator
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P08_LogsAggregator
	{
		public static void Main()
		{
			var counter = int.Parse(Console.ReadLine());
			var userToDuration = new SortedDictionary<string, int>();
			var userToIP = new SortedDictionary<string, List<string>>();

			for (var i = 0; i < counter; i++)
			{
				var input = Console.ReadLine().Split(' ');
				var user = input[1];
				var duration = int.Parse(input[2]);
				var IP = input[0];

				if (!userToDuration.ContainsKey(user))
				{
					userToDuration[user] = 0;
					userToIP[user] = new List<string>();
				}

				userToDuration[user] += duration;

				if (!userToIP[user].Contains(IP))
				{
					userToIP[user].Add(IP);
				}
			}

			var sortedUserToIP = new SortedDictionary<string, List<string>>();

			foreach (var user in userToIP)
			{
				var sortedIP = user.Value.OrderBy(x => x).ToList();
				sortedUserToIP[user.Key] = sortedIP;
			}

			foreach (var user in sortedUserToIP)
			{
				var duration = userToDuration[user.Key];
				var IPList = String.Join(", ", user.Value);

				Console.WriteLine("{0}: {1} [{2}]", user.Key, duration, IPList);
			}
		}
	}
}
