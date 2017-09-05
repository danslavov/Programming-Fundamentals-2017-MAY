namespace P05_CalculateTriangleArea
{
	using System;

	public class P05_CalculateTriangleArea
	{
		public static double TriangleArea (double side, double height)
		{
			return side * height / 2;
		}

		public static void Main()
		{
			var side = double.Parse(Console.ReadLine());
			var height = double.Parse(Console.ReadLine());
			var area = TriangleArea(side, height);
			Console.WriteLine(area);
		}
	}
}
