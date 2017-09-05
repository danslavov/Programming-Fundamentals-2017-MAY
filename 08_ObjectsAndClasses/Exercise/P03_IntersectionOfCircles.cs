namespace P03_IntersectionOfCircles
{
	using System;
	using System.Linq;

	public class P03_IntersectionOfCircles
	{
		public class Circle
		{
			public Point Center { get; set; }
			public double Radius { get; set; }

			public static bool CheckIfIntersect(Circle firstCircle, Circle secondCircle)
			{
				return firstCircle.Center.GetDistance(secondCircle.Center)
						<= firstCircle.Radius + secondCircle.Radius;
			}
		}

		public class Point
		{
			public double X { get; set; }
			public double Y { get; set; }

			public double GetDistance(Point otherPoint)
			{
				var deltaX = X - otherPoint.X;
				var deltaY = Y - otherPoint.Y;
				return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
			}
		}

		public static void Main()
		{
			var firstCircleInput = Console.ReadLine().Split()
				.Select(double.Parse).ToArray();
			var secondCircleInput = Console.ReadLine().Split()
				.Select(double.Parse).ToArray();
			var firstCircle = CreateCircle(firstCircleInput);
			var secondCircle = CreateCircle(secondCircleInput);

			Console.WriteLine(Circle.CheckIfIntersect(firstCircle, secondCircle)
				? "Yes" : "No");
		}

		public static Circle CreateCircle(double[] firstCircleInput)
		{
			return new Circle()
			{
				Center = new Point()
				{
					X = firstCircleInput[0],
					Y = firstCircleInput[1]
				},
				Radius = firstCircleInput[2]
			};
		}
	}
}
