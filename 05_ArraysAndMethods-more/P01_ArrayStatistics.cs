namespace P01_ArrayStatistics
{
	using System;
	using System.Linq;

	public class P01_ArrayStatistics
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var myArray = new int[input.Length];

			for (var i = 0; i < input.Length; i++)
			{
				myArray[i] = int.Parse(input[i]);
			}

			Console.WriteLine("Min = {0}\nMax = {1}\nSum = {2}\nAverage = {3}",
				myArray.Min(), myArray.Max(), myArray.Sum(), myArray.Average());
		}
	}
}
