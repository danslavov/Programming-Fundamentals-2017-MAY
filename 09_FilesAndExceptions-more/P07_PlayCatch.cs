namespace P07_PlayCatch
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P07_PlayCatch
	{
		public static void Main()
		{
			var numbers = Console.ReadLine().Split(). Select(int.Parse).ToArray();
			var exceptionCount = 0;

			while (exceptionCount < 3)
			{
				var input = Console.ReadLine().Split().ToArray();
				var command = input[0];
				try
				{
					if (command == "Replace")
					{
						Replace(input, numbers);
					}
					else if (command == "Print")
					{
						Print(input, numbers);
					}
					else
					{
						Show(input, numbers);
					}
				}
				catch (IndexOutOfRangeException wrongIndex)
				{
					Console.WriteLine("The index does not exist!");
					exceptionCount++;
				}
				catch (FormatException wrongFormat)
				{
					Console.WriteLine("The variable is not in the correct format!");
					exceptionCount++;
				}
			}
			Console.WriteLine(string.Join(", ", numbers));
		}

		public static void Show(string[] input, int[] numbers)
		{
			var index = int.Parse(input[1]);
			Console.WriteLine(numbers[index]);
		}

		private static void Print(string[] input, int[] numbers)
		{
			var startIndex = int.Parse(input[1]);
			var endIndex = int.Parse(input[2]);
			var result = new List<int>();
			for (int i = startIndex; i <= endIndex; i++)
			{
				result.Add(numbers[i]);
			}
			Console.WriteLine(string.Join(", ", result));
		}

		public static void Replace(string[] input, int[] numbers)
		{
			var index = int.Parse(input[1]);
			var element = int.Parse(input[2]);
			numbers[index] = element;
		}
	}
}
