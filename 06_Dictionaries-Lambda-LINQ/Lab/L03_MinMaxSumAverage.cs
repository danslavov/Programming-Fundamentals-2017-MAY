namespace P03_MinMaxSumAverage
{
	using System;
	using System.Linq;

	public class P03_MinMaxSumAverage
	{
		public static void Main()
		{
			var inputCount = int.Parse(Console.ReadLine());
			var inputNumbers = new int[inputCount];

			for (var i = 0; i < inputCount; i++)
			{
				inputNumbers[i] = int.Parse(Console.ReadLine());
			}

			var sum = inputNumbers.Sum();
			var min = inputNumbers.Min();
			var max = inputNumbers.Max();
			var average = inputNumbers.Average();

			Console.WriteLine($"Sum = {sum}\nMin = {min}\nMax = {max}" +
				$"\nAverage = {average}");
		}
	}
}
