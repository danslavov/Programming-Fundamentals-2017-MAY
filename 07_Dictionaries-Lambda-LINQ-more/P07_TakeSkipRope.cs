namespace P07_TakeSkipRope
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P07_TakeSkipRope
	{
		public static void Main()
		{
			var input = Console.ReadLine();
			var numbers = input
				.Where(x => (x >= 48 && x <= 57))
				.Select(x => (int)Char.GetNumericValue(x))
				.ToList();
			var nonNumbers = input.Where(x => (x < 48 || x > 57)).ToList();
			var takeList = takeEven(numbers, true);
			var skipList = takeEven(numbers, false);
			DecryptAndPrint(nonNumbers, takeList, skipList);
		}

		public static List<int> takeEven(List<int> sourceList, bool even)
		{
			var resultList = new List<int>();
			for (int i = even ? 0 : 1; i < sourceList.Count; i += 2)
			{
				resultList.Add(sourceList[i]);
			}
			return resultList;
		}

		public static void DecryptAndPrint(List<char> nonNumbers, List<int> takeList, List<int> skipList)
		{
			var skipCount = 0;

			for (int i = 0; i < takeList.Count; i++)
			{
				var takeCount = takeList[i];
				var result = nonNumbers
					.Skip(skipCount).Take(takeCount).ToList();
				foreach (var symbol in result)
				{
					Console.Write(symbol);
				}
				skipCount += (takeCount + skipList[i]);
			}
			Console.WriteLine();
		}
	}
}
