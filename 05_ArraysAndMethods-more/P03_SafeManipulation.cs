namespace P03_SafeManipulation
{
	using System;
	using System.Linq;

	public class P03_SafeManipulation
	{
		public static void Main()
		{
			var words = Console.ReadLine().Split().ToArray();

			while (true)
			{
				var input = Console.ReadLine().Split();

				var command = input[0];

				if (command == "END")
				{
					break;
				}

				if (command == "Reverse")
				{
					words = words.Reverse().ToArray();
				}
				else if (command == "Distinct")
				{
					words = words.Distinct().ToArray();
				}
				else if (command == "Replace")
				{
					var arrayIndex = int.Parse(input[1]);
					var newElement = input[2];

					if (arrayIndex < 0 || arrayIndex > words.Length - 1)
					{
						Console.WriteLine("Invalid input!");
						continue;
					}

					words[arrayIndex] = newElement;
				}
				else
				{
					Console.WriteLine("Invalid input!");
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
