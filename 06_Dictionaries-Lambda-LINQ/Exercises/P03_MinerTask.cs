namespace P03_MinerTask
{
	using System;
	using System.Collections.Generic;

	public class P03_MinerTask
	{
		public static void Main()
		{
			var task = new Dictionary<string, int>();
			var resource = Console.ReadLine();

			while (resource != "stop")
			{
				var quantity = int.Parse(Console.ReadLine());

				if (!task.ContainsKey(resource))
				{
					task[resource] = 0;
				}

				task[resource] += quantity;
				resource = Console.ReadLine();
			}

			foreach (var item in task)
			{
				Console.WriteLine(item.Key + " -> " + item.Value);
			}
		}
	}
}
