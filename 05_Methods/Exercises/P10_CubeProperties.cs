namespace P10_CubeProperties
{
	using System;

	public class P10_CubeProperties
	{
		public static double CubeFaceDiagonal(double a)
		{
			return Math.Sqrt(2 * a * a);
		}

		public static double CubeSpaceDiagonal(double a)
		{
			return Math.Sqrt(CubeFaceDiagonal(a) * CubeFaceDiagonal(a) + a * a);
		}

		public static double CubeVolume(double a)
		{
			double volume = a;
			for (int i = 0; i < 2; i++)
			{
				volume *= a;
			}
			return volume;
		}

		public static double CubeArea(double a)
		{
			return 6 * a * a;
		}

		public static void Main()
		{
			double side = double.Parse(Console.ReadLine());
			string cubeAttribute = Console.ReadLine();

			if (cubeAttribute == "face")
			{
				Console.WriteLine("{0:f2}", CubeFaceDiagonal(side));
			}
			if (cubeAttribute == "space")
			{
				Console.WriteLine("{0:f2}", CubeSpaceDiagonal(side));
			}
			if (cubeAttribute == "volume")
			{
				Console.WriteLine("{0:f2}", CubeVolume(side));
			}
			if (cubeAttribute == "area")
			{
				Console.WriteLine("{0:f2}", CubeArea(side));
			}
		}
	}
}
