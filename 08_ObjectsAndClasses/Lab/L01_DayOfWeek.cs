namespace L01_DayOfWeek
{
	using System;

	public class L01_DayOfWeek
	{
		public static void Main()
		{
			var inputDate = Console.ReadLine().Split('-');
			var year = int.Parse(inputDate[2]);
			var month = int.Parse(inputDate[1]);
			var day = int.Parse(inputDate[0]);
			var date = new DateTime(year, month, day);
			Console.WriteLine(date.DayOfWeek);
		}
	}
}
