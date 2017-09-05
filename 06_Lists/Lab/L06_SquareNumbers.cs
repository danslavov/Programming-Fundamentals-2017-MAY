namespace P06_SquareNumbers
{
	using System;
	using System.Collections.Generic;

	public static class P06_SquareNumbers
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split(' ');
			var numbers = new List<int>();
			foreach (var item in input)
			{
				int curNum = int.Parse(item);
				if (Math.Sqrt(curNum) == (int)(Math.Sqrt(curNum)))  // or (Math.Sqrt(curNum) % 1 == 0)
					numbers.Add(curNum);
			}
			numbers.Sort((x, y) => y.CompareTo(x));
			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}