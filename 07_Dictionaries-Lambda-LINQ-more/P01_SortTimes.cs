namespace P01_SortTimes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P01_SortTimes
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var times = FillList(input);
			times = times.OrderBy(x => x.Minute).ThenBy(x => x.Second).ToList();
			PrintList(times);
		}

		public static List<DateTime> FillList(string[] input)
		{
			var list = new List<DateTime>();

			foreach (var item in input)
			{
				var curTime = new DateTime();
				var minutes = int.Parse(item.Substring(0, 2));
				var seconds = int.Parse(item.Substring(3, 2));
				curTime = curTime.AddMinutes(minutes).AddSeconds(seconds);
				list.Add(curTime);
			}

			return list;
		}

		public static void PrintList(List<DateTime> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				var minutes = list[i].Minute;
				var seconds = list[i].Second;

				if (i != list.Count - 1)
				{
					Console.Write($"{minutes:d2}:{seconds:d2}, ");
				}
				else
				{
					Console.WriteLine($"{minutes:d2}:{seconds:d2}");
				}
			}
		}
	}
}
