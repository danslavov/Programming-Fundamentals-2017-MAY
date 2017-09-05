namespace P02_OddFilter
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P02_OddFilter
	{
		public static void Main()
		{
			var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			nums.RemoveAll(x => (x % 2 != 0));
			ConvertToOdd(nums);
			Console.WriteLine(String.Join(" ", nums));
		}

		public static void ConvertToOdd(List<int> list)
		{
			var average = list.Average();

			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] > average)
				{
					list[i]++;
				}
				else
				{
					list[i]--;
				}
			}
		}
	}
}
