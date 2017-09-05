namespace P08_CenterPoint
{
	using System;

	public class P08_CenterPoint
	{
		public static double GetDistanceToCenter(double x, double y)
		{
			return Math.Sqrt(x * x + y * y);
		}

		public static void Main()
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());

			double distance1 = GetDistanceToCenter(x1, y1);
			double distance2 = GetDistanceToCenter(x2, y2);
			if (distance1 <= distance2)
			{
				Console.WriteLine("({0}, {1})", x1, y1);
			}
			else
			{
				Console.WriteLine("({0}, {1})", x2, y2);
			}
		}
	}
}
