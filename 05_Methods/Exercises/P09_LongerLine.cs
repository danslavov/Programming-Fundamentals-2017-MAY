namespace P09_LongerLine
{
	using System;

	public static class P09_LongerLine
	{
		public static double GetLengthOfLine(double x, double y)
		{
			return Math.Sqrt(x * x + y * y);
		}

		public static double GetDistanceToCenter(double x, double y)
		{
			return GetLengthOfLine(x, y);
		}

		public static void Main()
		{
			double line1X1 = double.Parse(Console.ReadLine());  // -----------
			double line1Y1 = double.Parse(Console.ReadLine());  // -----------
			double line1X2 = double.Parse(Console.ReadLine());  // -----------
			double line1Y2 = double.Parse(Console.ReadLine());  // -----------
																//-- input --
			double line2X1 = double.Parse(Console.ReadLine());  // -----------
			double line2Y1 = double.Parse(Console.ReadLine());  // -----------
			double line2X2 = double.Parse(Console.ReadLine());  // -----------
			double line2Y2 = double.Parse(Console.ReadLine());  // -----------

			double line1X = Math.Abs(line1X1 - line1X2);        // -----------
			double line1Y = Math.Abs(line1Y1 - line1Y2);        // ---find----
			double line2X = Math.Abs(line2X1 - line2X2);        // --catheti--
			double line2Y = Math.Abs(line2Y1 - line2Y2);        // -----------

			double line1Legth = GetLengthOfLine(line1X, line1Y); //---length of----
			double line2Legth = GetLengthOfLine(line2X, line2Y); //---the 2 lines--

			double line1Distance1 = GetDistanceToCenter(line1X1, line1Y1); //-----------------------
			double line1Distance2 = GetDistanceToCenter(line1X2, line1Y2); //--distance to center---
			double line2Distance1 = GetDistanceToCenter(line2X1, line2Y1); //----of all 4 points----
			double line2Distance2 = GetDistanceToCenter(line2X2, line2Y2); //-----------------------

			if (line1Legth >= line2Legth)
			{
				if (line1Distance1 <= line1Distance2)
				{
					Console.WriteLine("({0}, {1})({2}, {3})",
						line1X1, line1Y1, line1X2, line1Y2);
				}
				else
				{
					Console.WriteLine("({0}, {1})({2}, {3})",
						line1X2, line1Y2, line1X1, line1Y1);
				}
			}
			else
			{
				if (line2Distance1 <= line2Distance2)
				{
					Console.WriteLine("({0}, {1})({2}, {3})",
						line2X1, line2Y1, line2X2, line2Y2);
				}
				else
				{
					Console.WriteLine("({0}, {1})({2}, {3})",
						line2X2, line2Y2, line2X1, line2Y1);
				}
			}
		}
	}
}
