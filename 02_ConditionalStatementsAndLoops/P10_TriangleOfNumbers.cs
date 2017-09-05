namespace P10_TriangleOfNumbers
{
	using System;

	public class P10_TriangleOfNumbers
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					if (j < i)
					{
						Console.Write(i + " ");
					}
					else
					{
						Console.Write(i);
					}
				}
				Console.WriteLine();
			}
		}
	}
}
