namespace P05_ClosestTwoPoints
{
	using System;
	using System.Linq;

	public class P05_ClosestTwoPoints
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var points = new Point[n];

			for (var i = 0; i < n; i++)
			{
				var coordinates = Console.ReadLine()
					.Split(' ').Select(int.Parse).ToArray();

				points[i] = new Point
				{
					X = coordinates[0],
					Y = coordinates[1]
				};
			}

			var minDistance = double.MaxValue;
			var firstPoint = new Point();
			var secondPoint = new Point();

			for (var i = 0; i < points.Length - 1; i++)
			{
				for (var j = i + 1; j < points.Length; j++)
				{
					var currentDistance = GetDistance(points[i], points[j]);
					 if (currentDistance < minDistance)
					{
						minDistance = currentDistance;
						firstPoint = points[i];
						secondPoint = points[j];
					}
				}
			}

			Console.WriteLine($"{minDistance:F3}\n({firstPoint.X}, {firstPoint.Y})\n" +
				$"({secondPoint.X}, {secondPoint.Y})");
		}

		public static double GetDistance(Point first, Point second)
		{
			var diffX = Math.Pow(first.X - second.X, 2);
			var diffY = Math.Pow(first.Y - second.Y, 2);
			return Math.Sqrt(diffX + diffY);
		}
	}
}
