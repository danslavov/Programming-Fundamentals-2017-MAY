namespace P04_DistanceBetweenPoints
{
	using System;
	using System.Linq;

	public class P04_DistanceBetweenPoints
	{
		public static void Main()
		{
			var firstPointCoordinates = Console.ReadLine()
				.Split(' ').Select(double.Parse).ToArray();

			var firstPoint = new P04_DistanceBetweenPointsPoint
			{
				X = firstPointCoordinates[0],
				Y = firstPointCoordinates[1]
			};

			var secondPointCoordinates = Console.ReadLine()
				.Split(' ').Select(double.Parse).ToArray();

			var secondPoint = new P04_DistanceBetweenPointsPoint
			{
				X = secondPointCoordinates[0],
				Y = secondPointCoordinates[1]
			};

			Console.WriteLine("{0:F3}", GetDistance(firstPoint, secondPoint));
		}

		public static double GetDistanceP04_DistanceBetweenPointsPoint first, P04_DistanceBetweenPointsPoint second)
		{
			var diffX = Math.Pow(first.X - second.X, 2);
			var diffY = Math.Pow(first.Y - second.Y, 2);
			return Math.Sqrt(diffX + diffY);
		}
	}
}
