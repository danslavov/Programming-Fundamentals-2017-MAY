namespace P04_GrabAndGo
{
	using System;
	using System.Linq;

	public class P04_GrabAndGo
	{
		public static int endIndex = -1;

		public static void Main()
		{
			var numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			var n = int.Parse(Console.ReadLine());

			FindResult(numbers, n);
		}

		public static void FindResult(int[] array, int n)
		{
			var sum = 0L;
			
			for (var i = array.Length - 1; i >= 0; i--)
			{
				if (array[i] == n)
				{
					endIndex = i;
					break;
				}
			}

			if (endIndex > 0)
			{
				for (var i = 0; i < endIndex; i++)
				{
					sum += array[i];
				}

				Console.WriteLine(sum);
			}
			else
			{
				Console.WriteLine("No occurrences were found!");
			}
		} 
	}
}
