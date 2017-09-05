namespace P03_SumAdjacentEqualNumbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P03_SumAdjacentEqualNumbers
	{
		public static void Main()
		{
			List<double> list = Console.ReadLine().Split(' ')
				.Select(double.Parse).ToList();
			bool stop;
			do
			{
				stop = true;
				for (int i = 0; i < list.Count - 1; i++)
				{
					if (list[i] == list[i + 1])
					{
						stop = false;
						list[i + 1] += list[i];
						list.Remove(list[i]);
					}
				}
			} while (!stop);

			Console.WriteLine(string.Join(" ", list));
		}
	}
}
