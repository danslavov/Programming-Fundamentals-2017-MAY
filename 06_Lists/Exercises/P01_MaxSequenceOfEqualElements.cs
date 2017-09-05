namespace P01_MaxSequenceOfEqualElements
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P01_MaxSequenceOfEqualElements
	{
		public static void Main()
		{
			var inputList = Console.ReadLine()
				.Split(' ').Select(double.Parse).ToList();
			var longestSequence = new List<double>();
			longestSequence.Add(inputList[0]);
			var currentSequence = new List<double>();
			currentSequence.Add(inputList[0]);
			int i = 1;

			do
			{
				if (inputList[i] == inputList[i - 1])
				{
					currentSequence.Add(inputList[i]);

					if (currentSequence.Count > longestSequence.Count)
					{
						longestSequence = new List<double>(currentSequence);
					}
				}
				else
				{
					currentSequence.Clear();
					currentSequence.Add(inputList[i]);
				}

				i++;
			}
			while (i < inputList.Count);

			Console.WriteLine(string.Join(" ", longestSequence));
		}
	}
}
