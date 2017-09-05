namespace P02_ManipulateArray
{
	using System;
	using System.Linq;

	public class P02_ManipulateArray
	{
		public static void Main()
		{
			var words = Console.ReadLine().Split().ToArray();
			var n = int.Parse(Console.ReadLine());

			for (var i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split();
				var command = input[0];

				if (command == "Reverse")
				{
					words = words.Reverse().ToArray();
				}
				else if (command == "Distinct")
				{
					words = words.Distinct().ToArray();
				}
				else
				{
					var arrayIndex = int.Parse(input[1]);
					var newElement = input[2];
					words[arrayIndex] = newElement;
				}
			}

			PrintArray(words);
		}

		public static void PrintArray(string[] array)
		{
			for (var i = 0; i < array.Length - 1; i++)
			{
				Console.Write(array[i] + ", ");
			}
			Console.WriteLine(array[array.Length - 1]);
		}
	}
}
