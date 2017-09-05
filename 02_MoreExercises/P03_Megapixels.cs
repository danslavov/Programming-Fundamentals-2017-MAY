namespace P03_Megapixels
{
	using System;

	public class P03_Megapixels
	{
		public static void Main()
		{
			var width = int.Parse(Console.ReadLine());
			var height = int.Parse(Console.ReadLine());
			var product = width * height / 1000000.0;
			double resolution = Math.Round(product, 1);
			Console.WriteLine("{0}x{1} => {2}MP", width, height, resolution);
		}
	}
}
