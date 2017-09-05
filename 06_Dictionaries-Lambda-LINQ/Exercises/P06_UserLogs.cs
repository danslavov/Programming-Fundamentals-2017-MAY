namespace P06_UserLogs
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P06_UserLogs
	{
		public static void Main()
		{
			var logs = new SortedDictionary<string, Dictionary<string, int>>();

			while (true)
			{
				var input = Console.ReadLine().Split(' ').ToArray();

				if (input.Contains("end"))
				{
					break;
				}

				var userName = input[2].Remove(0, 5);
				var IP = input[0].Remove(0, 3);

				if (!logs.ContainsKey(userName))
				{
					logs[userName] = new Dictionary<string, int>();
				}

				if (!logs[userName].ContainsKey(IP))
				{
					logs[userName][IP] = 0;
				}

				logs[userName][IP]++;
			}

			foreach (var user in logs)
			{
				Console.WriteLine(user.Key + ": ");
				var counter = 1;

				foreach (var IP in user.Value)
				{
					Console.Write("{0} => {1}{2}", IP.Key, IP.Value,
						(counter != user.Value.Count ? ", " : "."));
					counter++;
				}
				Console.WriteLine();
			}
		}
	}
}
