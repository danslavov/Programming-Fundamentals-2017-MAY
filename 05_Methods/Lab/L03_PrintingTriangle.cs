namespace P03_PrintingTriangle
{
	using System;

	public class P03_PrintingTriangle
	{
		public static void PrintLine(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				PrintLine(1, i);
			}
			for (int i = n; i >= 1; i--)
			{
				PrintLine(1, i - 1);
			}
		}
	}
}
