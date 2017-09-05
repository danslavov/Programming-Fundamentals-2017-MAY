namespace P07_GreaterOfTwoValues
{
	using System;

	public class P07_GreaterOfTwoValues
	{
		public static int GetMax(int a, int b)
		{
			return a >= b ? a : b;
		}

		public static char GetMax(char a, char b)
		{
			return a >= b ? a : b;
		}

		public static string GetMax(string a, string b)
		{
			if (a.CompareTo(b) >= 0)
			{
				return a;
			}
			else
			{
				return b;
			}
		}

		public static void Main()
		{
			string variableType = Console.ReadLine();

			if (variableType == "int")
			{
				var first = int.Parse(Console.ReadLine());
				var second = int.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(first, second));
			}
			else if (variableType == "char")
			{
				var first = char.Parse(Console.ReadLine());
				var second = char.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(first, second));
			}
			else
			{
				var first = Console.ReadLine();
				var second = Console.ReadLine();
				Console.WriteLine(GetMax(first, second));
			}
		}
	}
}
