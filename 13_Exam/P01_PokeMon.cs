namespace P01_PokeMon
{
	using System;

	public class P01_PokeMon
	{
		public static void Main()
		{
			var powerN = int.Parse(Console.ReadLine());
			var startPower = powerN;
			var distanceM = int.Parse(Console.ReadLine());
			var exhaustionFactorY = int.Parse(Console.ReadLine());
			var pokeCount = 0;

			while (powerN >= distanceM)
			{
				if (powerN == startPower / 2 && exhaustionFactorY != 0)
				{
					powerN /= exhaustionFactorY;
				}
				if (powerN < distanceM)
				{
					break;
				}
				powerN -= distanceM;
				pokeCount++;
			}
			Console.WriteLine(powerN);
			Console.WriteLine(pokeCount);
		}
	}
}
