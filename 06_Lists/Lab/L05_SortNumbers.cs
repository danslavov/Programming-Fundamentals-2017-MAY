namespace P05_SortNumbers
{
	using System;
	using System.Collections.Generic;

	public class P05_SortNumbers
	{
		public static void Main()
		{
			var inputString = Console.ReadLine().Split(' ');
			var listOfNumbers = new List<double>();
			foreach (var num in inputString)
			{
				listOfNumbers.Add(double.Parse(num));
			}
			listOfNumbers.Sort();
			Console.WriteLine(string.Join(" <= ", listOfNumbers));
		}
	}
}