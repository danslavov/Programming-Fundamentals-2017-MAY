namespace P07_PrimesInGivenRange
{
	using System;

	public class P07_PrimesInGivenRange
	{
		public static void PrimeRange(int begin, int end)
		{
			bool isFound = false;

			for (int currentNumber = begin; currentNumber <= end; currentNumber++)
			{
				bool isPrime = true;
				if (currentNumber <= 1)
				{
					isPrime = false;
					continue;
				}

				for (int divider = 2; divider <= Math.Sqrt(currentNumber); divider++)
				{
					if (currentNumber % divider == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime)
				{
					if (isFound)
					{
						Console.Write(", ");
					}
					Console.Write("{0}", currentNumber);
					isFound = true;
				}
			}
			Console.WriteLine();
		}

		public static void Main()
		{
			var begin = int.Parse(Console.ReadLine());
			var end = int.Parse(Console.ReadLine());
			PrimeRange(begin, end);
		}
	}
}
