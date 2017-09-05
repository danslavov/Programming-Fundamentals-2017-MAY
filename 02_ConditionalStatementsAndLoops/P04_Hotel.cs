namespace P04_Hotel
{
	using System;

	public class P04_Hotel
	{
		public static void Main()
		{
			var month = Console.ReadLine();
			var nights = int.Parse(Console.ReadLine());
			var priceStudioPerNight = 0d;
			var priceDoublePerNight = 0d;
			var priceSuitePerNight = 0d;

			switch (month)
			{
				case "May":
				case "October":
					priceStudioPerNight = (nights > 7) ? 47.5 : 50;
					priceDoublePerNight = 65;
					priceSuitePerNight = 75;
					break;
				case "June":
				case "September":
					priceStudioPerNight = 60;
					priceDoublePerNight = (nights > 14) ? 64.8 : 72;
					priceSuitePerNight = 82;
					break;
				case "July":
				case "August":
				case "December":
					priceStudioPerNight = 68;
					priceDoublePerNight = 77;
					priceSuitePerNight = (nights > 14) ? 75.65 : 89;
					break;
			}

			var priceStudio = priceStudioPerNight *
				(nights > 7 & (month == "September" || month == "October") ?
				nights - 1 : nights);
			var priceDouble = priceDoublePerNight * nights;
			var priceSuite = priceSuitePerNight * nights;

			Console.WriteLine($"Studio: {priceStudio:F2} lv.\n" +
				$"Double: {priceDouble:F2} lv.\nSuite: {priceSuite:F2} lv.");
		}
	}
}
