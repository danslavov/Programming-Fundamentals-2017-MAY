namespace P01_SinoTheWalker
{
	using System;
	using System.Globalization;

	public class P01_SinoTheWalker
	{
		public static void Main()
		{
			var startTime = DateTime.ParseExact(Console.ReadLine(),
				"H:m:s", CultureInfo.InstalledUICulture);
			var steps = int.Parse(Console.ReadLine());
			var secPerStep = int.Parse(Console.ReadLine());
			var totalSec = ((long)steps * secPerStep) % (24 * 3600);      // ignore full days
			var endTime = startTime.AddSeconds(totalSec);
			Console.WriteLine($"Time Arrival: " +
				$"{endTime:HH:mm:ss}");
		}
	}
}
