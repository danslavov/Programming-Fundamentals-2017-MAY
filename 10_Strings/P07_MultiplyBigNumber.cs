namespace P07_MultiplyBigNumber
{
	using System;
	using System.Text;

	public class P07_MultiplyBigNumber
	{
		public static void Main()
		{
			var reallyBigNumber = Reverse(new StringBuilder(
				Console.ReadLine().TrimStart('0')));
			var secondNumber = byte.Parse(Console.ReadLine().TrimStart('0'));
			Console.WriteLine(CalculateSum(reallyBigNumber, secondNumber));
		}

		public static StringBuilder CalculateSum(
			StringBuilder reallyBigNumber, byte secondNumber)
		{
			var result = new StringBuilder();
			var subTotal = 0;
			for (int i = 0; i < reallyBigNumber.Length; i++)
			{
				var firstNumber = byte.Parse(reallyBigNumber[i].ToString());
				subTotal = (subTotal / 10) + (firstNumber * secondNumber);
				result.Append(subTotal % 10);
			}
			if (subTotal > 9)
			{
				result.Append(subTotal / 10);
			}
			return Reverse(result);
		}

		public static StringBuilder Reverse(StringBuilder text)
		{
			var reversed = new StringBuilder();
			for (int i = text.Length - 1; i >= 0; i--)
			{
				reversed.Append(text[i]);
			}
			return reversed;
		}
	}
}
