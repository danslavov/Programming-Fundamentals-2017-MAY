namespace P06_FoldAndSum
{
	using System;
	using System.Linq;

	public class P06_FoldAndSum
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var firstRow = input
				.Take(input.Count / 4)
				.Reverse()
				.Concat(input.Skip(input.Count * 3 / 4).Reverse())
				.ToList();
			var secondRow = input
				.Skip(input.Count / 4)
				.Take(input.Count / 2)
				.ToList();

			var sum = firstRow.Select((x, index) => x + secondRow[index]);

			Console.WriteLine(string.Join(" ", sum));
		}
	}
}
