namespace P02_NumberChecker
{
	using System;

	public class P02_NumberChecker
	{
		public static void Main()
		{
			var inputNumber = double.Parse(Console.ReadLine());
			var isInteger = inputNumber % 1 == 0;
			
			if (isInteger)
			{
				Console.WriteLine("integer");
			}
			else
			{
				Console.WriteLine("floating-point");
			}
		}
	}
}
