namespace P01_ConvertFromBase_10ToBase_N
{
	using System;
	using System.Numerics;

	public class P01_ConvertFromBase10ToBaseN
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var basis = byte.Parse(input[0]);
			var num10 = BigInteger.Parse(input[1]);
			var result = string.Empty;
			while (num10 > 0)
			{
				var rem = num10 % basis;
				result += rem;
				num10 /= basis;
			}

			for (var i = result.Length - 1; i >= 0; i--)
			{
				Console.Write(result[i]);
			}
			Console.WriteLine();
		}
	}
}
