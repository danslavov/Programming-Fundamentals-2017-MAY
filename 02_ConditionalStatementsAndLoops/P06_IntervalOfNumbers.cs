namespace P06_IntervalOfNumbers
{
	using System;

	public class P06_IntervalOfNumbers
	{
		public static void Main()
		{
			var firstNumber = int.Parse(Console.ReadLine());
			var secondNumber = int.Parse(Console.ReadLine());

			for (int i = Math.Min(firstNumber, secondNumber);
				i <= Math.Max(firstNumber, secondNumber); i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
