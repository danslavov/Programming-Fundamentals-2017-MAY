namespace P06_RectanglePosition
{
	using System;
	using System.Linq;

	class P06_RectanglePosition			// 66/100
	{
		static void Main()
		{
			var firstRectangle = ReadRectangle(Console.ReadLine());
			var secondRectangle = ReadRectangle(Console.ReadLine());
			Console.WriteLine(firstRectangle.IsInside(secondRectangle) ?
				"Inside" : "Not inside");
		}

		public static Rectangle ReadRectangle(string input)
		{
			var coordinates = input.Split(' ').Select(int.Parse).ToArray();

			return new Rectangle
			{
				Top = coordinates[0],
				Left = coordinates[1],
				Width = coordinates[2],
				Height = coordinates[3],
			};
		}
	}
}
