namespace P07_CountNumbers
{
	using System;
	public class P07_CountNumbers_AfterSorting
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split(' ');
			var nums = new int[input.Length];
			for (var i = 0; i < nums.Length; i++)
			{
				nums[i] = int.Parse(input[i]);
			}
			Array.Sort(nums);
			var occurrences = 1;

			for (var i = 0; i < nums.Length; i++)
			{
				if (i == nums.Length - 1)
				{
					Console.WriteLine("{0} -> {1}", nums[i], occurrences);
				}
				else
				{
					if (nums[i] != nums[i + 1])
					{
						Console.WriteLine("{0} -> {1}", nums[i], occurrences);
						occurrences = 1;
					}
					else
					{
						occurrences++;
					}
				}
			}
		}
	}
}
