namespace P05_WeatherForecast
{
	using System;

	public class P05_WeatherForecast_forJudge
	{
		public static void Main()
		{
			var number = float.Parse(Console.ReadLine());

			if (number % 1 == 0)
			{
				if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
				{
					Console.WriteLine("Sunny");
				}

				else if (number >= int.MinValue && number <= int.MaxValue)
				{
					Console.WriteLine("Cloudy");
				}

				else if (number >= long.MinValue && number <= long.MaxValue)
				{
					Console.WriteLine("Windy");
				}
			}

			else
			{
				Console.WriteLine("Rainy");
			}
		}
	}
}
