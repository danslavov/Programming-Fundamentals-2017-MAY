namespace P12_BeerKegs
{
	using System;

	public class P12_BeerKegs
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			var resultName = String.Empty;
			var maxVolume = 0.0;

			for (byte i = 0; i < n; i++)
			{
				var name = Console.ReadLine();
				var radius = float.Parse(Console.ReadLine());
				var height = int.Parse(Console.ReadLine());
				var volume = Math.PI * radius * radius * height;

				if (volume > maxVolume)
				{
					resultName = name;
					maxVolume = volume;
				}
			}

			Console.WriteLine(resultName);
		}
	}
}
