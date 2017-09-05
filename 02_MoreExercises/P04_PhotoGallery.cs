namespace P04_PhotoGallery
{
	using System;

	public class P04_PhotoGallery
	{
		public static void Main()
		{
			var data = new int[9];
			for (int i = 0; i < data.Length; i++)
			{
				data[i] = int.Parse(Console.ReadLine());
			}

			var name = String.Format("DSC_{0:D4}.jpg", data[0]);
			var dateTime = new DateTime(data[3], data[2], data[1], data[4], data[5], 0);
			var size = ConvertSize(data[6]);
			var resolution = String.Format($"{data[7]}x{data[8]}");
			var orientation = GetOrientation(data[7], data[8]);

			Console.WriteLine($"Name: {name}\nDate Taken: {dateTime:dd/MM/yyyy HH:mm}\n" +
				$"Size: {size}\nResolution: {resolution} ({orientation})");
		}

		public static string ConvertSize(int size)
		{
			var output = String.Empty;
			if (size < 1000)
			{
				output = size + "B";
			}
			else if (size < 1000000)
			{
				output = Math.Round((double)size / 1000, 1) + "KB";
			}
			else
			{
				output = Math.Round((double)size / 1000000, 1) + "MB";
			}

			return output;
		}

		public static string GetOrientation(int width, int height)
		{
			if (width > height)
			{
				return "landscape";
			}
			else if (height > width)
			{
				return "portrait";
			}
			else
			{
				return "square";
			}
		}
	}
}
