namespace P14_BoatSimulator
{
	using System;

	public class P14_BoatSimulator
	{
		public static void Main()
		{
			var firstBoatChar = char.Parse(Console.ReadLine());
			var secondBoatChar = char.Parse(Console.ReadLine());
			var n = byte.Parse(Console.ReadLine());
			var firstBoatProgress = 0;
			var secondBoatProgress = 0;

			for (byte i = 1; i <= n; i++)
			{
				if (firstBoatProgress >= 50 || secondBoatProgress >= 50)
				{
					goto print;
				}

				var progressAsString = Console.ReadLine();

				if (progressAsString == "UPGRADE")
				{
					firstBoatChar = (char)(firstBoatChar + 3);
					secondBoatChar = (char)(secondBoatChar + 3);
				}

				else
				{
					if (i % 2 != 0)
					{
						firstBoatProgress += progressAsString.Length;
					}
					else
					{
						secondBoatProgress += progressAsString.Length;
					}
				}
			}

			print:
			Console.WriteLine((firstBoatProgress > secondBoatProgress) ?
				firstBoatChar : secondBoatChar);
		}
	}
}
