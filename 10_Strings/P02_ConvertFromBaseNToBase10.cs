namespace P02_ConvertFromBaseNToBase10
{
	using System;
	using System.Numerics;

	public class P02_ConvertFromBaseNToBase10
	{
		public static void Main()
		{
				var input = Console.ReadLine().Split();
				var basis = BigInteger.Parse(input[0]);
				var source = ReverseString(input[1]);
				BigInteger result = 0;

				for (var i = 0; i < source.Length; i++)
				{
					var currentDigit = source[i].ToString();
					result += BigInteger.Parse(currentDigit)
						* BigInteger.Pow(basis, i);
				}
				Console.WriteLine(result);
			}

		public static string ReverseString(string text)
		{
			var reversedText = "";
			for (var i = text.Length - 1; i >= 0; i--)
			{
				reversedText += text[i];
			}
			return reversedText;
		}
	}
}
