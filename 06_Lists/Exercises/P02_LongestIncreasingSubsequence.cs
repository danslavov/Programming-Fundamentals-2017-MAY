namespace P02_LongestIncreasingSubsequence
{
	using System;
	using System.Collections.Generic;

	public class P02_LongestIncreasingSubsequence
	{
		public static void Main()
		{
			var inputString = Console.ReadLine().Split();
			var input = new List<int>();
			foreach (var number in inputString)
			{
				input.Add(int.Parse(number));
			}

			var len = new List<int>(input);
			var prev = new List<int>(input);
			var maxLen = 0;
			var lastIndex = -1;

			for (var i = 0; i < input.Count; i++)
			{
				len[i] = 1;
				prev[i] = -1;

				for (var j = 0; j < i; j++)
				{
					if ((input[j] < input[i]) && (len[j] + 1 > len[i]))
					{
						len[i] = len[i] + 1;
						prev[i] = j;
					}
				}

				if (maxLen < len[i])
				{
					maxLen = len[i];
					lastIndex = i;
				}
			}

			Console.WriteLine(string.Join(" ",
					restoreLIS(input, prev, lastIndex)));
		}

		public static List<int> restoreLIS(List<int> input, List<int> prev, int index)
		{
			var LIS = new List<int>();

			while (index >= 0)
			{
				LIS.Add(input[index]);
				index = prev[index];
			}

			LIS.Reverse();
			return LIS;
		}
	}
}
