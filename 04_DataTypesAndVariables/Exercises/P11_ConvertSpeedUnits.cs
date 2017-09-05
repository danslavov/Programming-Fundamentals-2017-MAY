namespace P11_ConvertSpeedUnits
{
	using System;

	public class Program
	{
		public static void Main()
		{
			int distance = int.Parse(Console.ReadLine());
			int timeHours = int.Parse(Console.ReadLine());
			int timeMinutes = int.Parse(Console.ReadLine());
			int timeSeconds = int.Parse(Console.ReadLine());

			timeSeconds += timeHours * 3600 + timeMinutes * 60;
			float speedMetersPerSecond = (float)distance / timeSeconds;
			float speedKilometersPerHour = speedMetersPerSecond * 3.6f;
			float speedMilesPerHour = speedKilometersPerHour / 1.609f;
			Console.WriteLine("{0:F6}\n{1:F6}\n{2:F6}",
				speedMetersPerSecond, speedKilometersPerHour, speedMilesPerHour);
		}
	}
}
