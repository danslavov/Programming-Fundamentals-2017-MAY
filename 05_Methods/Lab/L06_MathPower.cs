namespace P06_MathPower
{
	using System;

	public class P06_MathPower
	{
		public static double Power (double baseNumber, double exponent)
		{
			double result = 1;
			for (int i = 0; i < exponent; i++)
			{
				result *= baseNumber;
			}
			return result;
		}

		public static void Main()
		{
			Console.Write("Enter base: ");
			var basis = double.Parse(Console.ReadLine());
			Console.Write("Enter exponent: ");
			var exp = double.Parse(Console.ReadLine());
			Console.WriteLine(Power(basis, exp));
		}
	}
}
