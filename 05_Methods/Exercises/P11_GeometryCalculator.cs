namespace P11_GeometryCalculator
{
	using System;

	public class P11_GeometryCalculator
	{
		public static void GetTriangleArea(double side, double height)
		{
			double result = side * height / 2;
			Console.WriteLine("{0:f2}", result);
		}

		public static void GetSquareArea(double side)
		{
			double result = side * side;
			Console.WriteLine("{0:f2}", result);
		}

		public static void GetRectangleleArea(double firstSide, double secondfSide)
		{
			double result = firstSide * secondfSide;
			Console.WriteLine("{0:f2}", result);
		}

		public static void GetCircleArea(double radius)
		{
			double result = Math.PI * radius * radius;
			Console.WriteLine("{0:f2}", result);
		}

		public static void Main()
		{
			string figureType = Console.ReadLine();
			double side = double.Parse(Console.ReadLine());

			if (figureType == "triangle")
			{
				double height = double.Parse(Console.ReadLine());
				GetTriangleArea(side, height);
			}
			else if (figureType == "square")
			{
				GetSquareArea(side);
			}
			else if (figureType == "rectangle")
			{
				double secondSide = double.Parse(Console.ReadLine());
				GetRectangleleArea(side, secondSide);
			}
			else
			{
				GetCircleArea(side);
			}
		}
	}
}
