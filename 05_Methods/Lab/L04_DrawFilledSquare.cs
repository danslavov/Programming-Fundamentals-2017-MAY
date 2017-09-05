namespace P04_DrawFilledSquare
{ 
	using System;
	public class P04_DrawFilledSquare
	{
		public static void PrintBorderRow(string symbol, int count)
		{
			for (int i = 0; i < count; i++)
			{
				Console.Write(symbol);
			}
			Console.WriteLine();
		}

		public static void PrintMiddleRow(string symbol, int count)
		{
			Console.Write("-");
			for (int i = 0; i < count; i++)
			{
				Console.Write(symbol);
			}
			Console.WriteLine("-");
		}

		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			PrintBorderRow("-", 2 * n);
			for (int i = 0; i < n - 2; i++)
			{
				PrintMiddleRow("\\/", n - 1);
			}
			PrintBorderRow("-", 2 * n);
		}
	}
}
