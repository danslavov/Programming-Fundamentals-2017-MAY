namespace P06_CatchThief
{
	using System;

	public class P06_CatchThief
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

			Console.WriteLine(ID);
		}
	}
}
