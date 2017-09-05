namespace P04_TouristInformation
{
	using System;

	public class P04_TouristInformation
	{
		public static void Main()
		{
			var fromUnit = Console.ReadLine();
			var fromAmount = decimal.Parse(Console.ReadLine());
			var multiplier = 1.0M;
			var toUnit = string.Empty;

			switch (fromUnit)
			{
				case "miles":
					multiplier = 1.6M;
					toUnit = "kilometers";
					break;
				case "inches":
					multiplier = 2.54M;
					toUnit = "centimeters";
					break;
				case "feet":
					multiplier = 30M;
					toUnit = "centimeters";
					break;
				case "yards":
					multiplier = 0.91M;
					toUnit = "meters";
					break;
				case "gallons":
					multiplier = 3.8M;
					toUnit = "liters";
					break;
			}

			var toAmount = fromAmount * multiplier;

			Console.WriteLine($"{fromAmount} {fromUnit} = " +
				$"{toAmount:F2} {toUnit}");
		}
	}
}
