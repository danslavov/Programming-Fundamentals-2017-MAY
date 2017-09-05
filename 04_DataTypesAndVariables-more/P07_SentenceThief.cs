namespace P07_SentenceThief
{
	using System;

	public class P07_SentenceThief
	{
		public static void Main()
		{
			var type = Console.ReadLine();
			var n = byte.Parse(Console.ReadLine());
			decimal minDiff = decimal.MaxValue;
			long ID = 0;

			for (byte i = 0; i < n; i++)
			{
				var num = long.Parse(Console.ReadLine());
				decimal maxValue = 0;

				switch (type)
				{
					case "sbyte":
						maxValue = sbyte.MaxValue;
						break;
					case "int":
						maxValue = int.MaxValue;
						break;
					case "long":
						maxValue = long.MaxValue;
						break;
				}

				decimal diff = maxValue - num;

				if (diff >= 0 && diff < minDiff)
				{
					minDiff = diff;
					ID = num;
				}
			}

			var sentencedYears = 0.0;

			if (ID >= 0)
			{
				sentencedYears = Math.Ceiling(ID / 127.0);
			}
			else
			{
				sentencedYears = Math.Ceiling(ID / -128.0);
			}

			Console.Write($"Prisoner with id {ID} is sentenced to " +
				$"{sentencedYears} ");
			Console.WriteLine(sentencedYears == 1 ? "year" : "years");
		}
	}
}
