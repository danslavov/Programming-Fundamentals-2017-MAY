namespace P10_PriceChangeAlert
{
	using System;

	public class P10_PriceChangeAlert
	{
		public static void Main()
		{
			int priceNumber = int.Parse(Console.ReadLine());
			double treshold = double.Parse(Console.ReadLine()) * 100.0;
			double previousPrice = double.Parse(Console.ReadLine());

			for (int i = 0; i < priceNumber - 1; i++)
			{
				double currentPrice = double.Parse(Console.ReadLine());
				double difference = Percentage(previousPrice, currentPrice);
				bool isSignificantDifference = HasDifference(difference, treshold);
				string message = Get(currentPrice, previousPrice, difference, isSignificantDifference);
				Console.WriteLine(message);
				previousPrice = currentPrice;
			}
		}

		private static string Get(double current, double previous, double difference, bool isSignificantDifference)
		{
			string result = "";
			if (difference == 0)
			{
				result = string.Format("NO CHANGE: {0}", current);
			}
			else if (!isSignificantDifference)
			{
				result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previous, current, difference);
			}
			else if (isSignificantDifference && (difference > 0))
			{
				result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previous, current, difference);
			}
			else if (isSignificantDifference && (difference < 0))
				result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previous, current, difference);
			return result;
		}
		private static bool HasDifference(double difference, double treshold)
		{
			return (Math.Abs(difference) >= treshold);
		}

		private static double Percentage(double lastPrice, double currentPrice)
		{
			return 100 * (currentPrice - lastPrice) / lastPrice;
		}
	}
}
