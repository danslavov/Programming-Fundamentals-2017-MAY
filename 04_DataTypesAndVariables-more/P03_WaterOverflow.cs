namespace P03_WaterOverflow
{
	using System;

	public class P03_WaterOverflow
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			ushort volume = 0;

			for (byte i = 0; i < n; i++)
			{
				ushort addedVolume = ushort.Parse(Console.ReadLine());
				if (addedVolume <= 255 - volume)
				{
					volume += addedVolume;
				}
				else
				{
					Console.WriteLine("Insufficient capacity!");
				}
			}

			Console.WriteLine(volume);
		}
	}
}
