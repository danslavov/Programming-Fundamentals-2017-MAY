namespace P03_ArrayManipulator				// 91/100 in Judge
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P03_ArrayManipulator
	{
		public static void Main()
		{
			var list = Console.ReadLine()
				.Split(' ').Select(int.Parse).ToList();

			while (true)
			{
				var input = Console.ReadLine().Split(' ');
				var command = input[0];
				var values = new List<int>();

				if (input.Length > 1)
				{
					for (int i = 1; i < input.Length; i++)
					{
						values.Add(int.Parse(input[i]));
					}
				}

				switch (command)
				{
					case "add":
						list.Insert(values[0], values[1]);
						break;
					case "addMany":
						AddMany(list, values);
						break;
					case "contains":
						Contains(list, values);
						break;
					case "remove":
						list.Remove(list[values[0]]);
						break;
					case "shift":
						Shift(list, values);
						break;
					case "sumPairs":
						list = sumPairs(list);
						break;
					default:
						Print(list);
						return;
				}
			}
		}

		public static void AddMany(List<int> list, List<int> values)
		{
			var index = values[0];
			values.Remove(values[0]);
			list.InsertRange(index, values);
		}

		public static void Contains(List<int> list, List<int> values)
		{
			var notFound = true;

			for (var i = 0; i < list.Count; i++)
			{
				if (list[i] == values[0])
				{
					Console.WriteLine(i);
					notFound = false;
					return;
				}
			}

			if (notFound)
			{
				Console.WriteLine("-1");
			}
		}

		public static void Shift(List<int> list, List<int> values)
		{
			var positions = values[0];
			var tempList = new List<int>(list);

			for (var i = 0; i < list.Count; i++)
			{
				list[i] = tempList[(i + positions) % tempList.Count];
			}
		}

		public static List<int> sumPairs(List<int> list)
		{
			var newList = new List<int>();

			for (var i = 0; i < list.Count; i += 2)
			{
				if ((list.Count % 2 != 0) && (i == list.Count - 1))
				{
					newList.Add(list[i]);
				}
				else
				{
					newList.Add(list[i] + list[i + 1]);
				}
			}

			return newList;
		}

		public static void Print(List<int> result)
		{
			Console.WriteLine("[" + string.Join(", ", result) + "]");
		}
	}
}
