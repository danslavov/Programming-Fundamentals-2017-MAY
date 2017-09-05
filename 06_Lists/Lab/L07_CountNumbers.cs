namespace P07_CountNumbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P07_CountNumbers
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split(' ');
			var nums = new int[input.Length];
			for (int i = 0; i < nums.Length; i++)
			{
				nums[i] = int.Parse(input[i]);
			}
			var maxNumber = nums.Max();
			var counts = new int[maxNumber + 1];
			foreach (var num in nums)
			{
				counts[num]++;
			}
			for (var i = 0; i < counts.Length; i++)
			{
				if (counts[i] > 0)
				{
					Console.WriteLine("{0} -> {1}", i, counts[i]);
				}
			}
		}
	}
}
