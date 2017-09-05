namespace P01_CountWorkingDays
{
	using System;
	using System.Globalization;

	public class P01_CountWorkingDays
	{
		public class Holiday
		{
			public int Month { get; set; }
			public int Day { get; set; }

			public bool CheckIfHoliday(DateTime date)
			{
				return (date.Month == Month) && (date.Day == Day);
			}
		}

		public static void Main()
		{
			var firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
				CultureInfo.InstalledUICulture);
			var secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
				CultureInfo.InstalledUICulture);

			var holidays = new Holiday[]
			{
				new Holiday() { Month = 1, Day = 1},
				new Holiday() { Month = 3, Day = 3},
				new Holiday() { Month = 5, Day = 1},
				new Holiday() { Month = 5, Day = 6},
				new Holiday() { Month = 5, Day = 24},
				new Holiday() { Month = 9, Day = 6},
				new Holiday() { Month = 9, Day = 22},
				new Holiday() { Month = 11, Day = 1},
				new Holiday() { Month = 12, Day = 24},
				new Holiday() { Month = 12, Day = 25},
				new Holiday() { Month = 12, Day = 26},
			};

			Console.WriteLine(CountWorkingDays(firstDate, secondDate, holidays));
		}

		public static int CountWorkingDays(
			DateTime firstDate, DateTime secondDate, Holiday[] holidays)
		{
			var workingDays = 0;

			for (var date = firstDate; date <= secondDate; date = date.AddDays(1))
			{
				if (date.DayOfWeek != DayOfWeek.Saturday &&
					date.DayOfWeek != DayOfWeek.Sunday)
				{
					var isHoliday = false;

					foreach (var h in holidays)
					{
						if (h.CheckIfHoliday(date))
						{
							isHoliday = true;
							break;
						}
					}
					if (!isHoliday)
					{
						workingDays++;
					}
				}
			}
			return workingDays;
		}
	}
}
