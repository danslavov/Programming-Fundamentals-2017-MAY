namespace P03_EnduranceRally
{
	using System;
	using System.Linq;

	public class P03_EnduranceRally
	{
		public static void Main()
		{
			var names = Console.ReadLine().Split();
			var track = Console.ReadLine()
				.Split()
				.Select(double.Parse)
				.ToArray();
			var checkpoints = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			foreach (var name in names)
			{
				CalculateAndPrintResult(name, track, checkpoints);
			}
		}

		public static void CalculateAndPrintResult(
			string name, double[] track, int[] checkpoints)
		{
			var fuel = (double)name[0];
			for (var i = 0; i < track.Length; i++)
			{
				if (checkpoints.Contains(i))
				{
					fuel += track[i];
				}
				else
				{
					fuel -= track[i];
					if (fuel <= 0)      // {name} cannot finish with {fuel} == 0
					{
						Console.WriteLine($"{name} - reached {i}");
						return;
					}
				}
			}
			Console.WriteLine($"{name} - fuel left {fuel:F2}");
		}
	}
}
