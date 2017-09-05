namespace P05_WeatherForecast
{
	using System;

	public class P05_WeatherForecast
	{
		public static void Main()
		{
			var input = Console.ReadLine();

			var isSByte = sbyte.TryParse(input, out sbyte resultSByte);

			if (isSByte)
			{
				Console.WriteLine("Sunny");
			}

			else
			{
				var isInt = int.TryParse(input, out int resultInt);

				if (isInt)
				{
					Console.WriteLine("Cloudy");
				}

				else
				{
					var isLong = long.TryParse(input, out long resultLong);

					if (isLong)
					{
						Console.WriteLine("Windy");
					}

					else
					{
						var isFloat = float.TryParse(input, out float resultFloat);

						if (isFloat)
						{
							Console.WriteLine("Rainy");
						}
					}
				}
			}
		}
	}
}
