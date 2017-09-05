namespace P08_HouseBuilder
{
	using System;
	using System.Numerics;

	public class P08_HouseBuilder
	{
		public static void Main()
		{
			BigInteger firstPrice = BigInteger.Parse(Console.ReadLine());
			BigInteger secondPrice = BigInteger.Parse(Console.ReadLine());
			BigInteger priceInt;
			BigInteger priceByte;

			if (firstPrice < 128)
			{
				priceByte = firstPrice;
				priceInt = secondPrice;
			}
			else
			{
				priceByte = secondPrice;
				priceInt = firstPrice;
			}

			BigInteger totalPrice = priceInt * 10 + priceByte * 4;

			Console.WriteLine(totalPrice);
		}
	}
}
