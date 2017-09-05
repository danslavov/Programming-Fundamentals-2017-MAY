namespace P08_CaloriesCounter
{
	using System;

	public class P08_CaloriesCounter
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var calories = 0;

			for (var i = 0; i < n; i++)
			{
				var ingredient = Console.ReadLine().ToLower();

				switch (ingredient)
				{
					case "cheese":
						calories += 500;
						break;
					case "tomato sauce":
						calories += 150;
						break;
					case "salami":
						calories += 600;
						break;
					case "pepper":
						calories += 50;
						break;
				}
			}

			Console.WriteLine("Total calories: {0}", calories);
		}
	}
}
