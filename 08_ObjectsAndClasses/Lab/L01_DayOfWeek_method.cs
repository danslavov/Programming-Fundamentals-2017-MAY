namespace L01_DayOfWeek
{
	using System;
	using System.Globalization;

	public class L01_DayOfWeek_method
	{
		public static void Main()
		{
			Console.WriteLine(DateTime
				.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture)
				.DayOfWeek);
		}
	}
}
