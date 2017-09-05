namespace P18_SequenceOfCommands
{
	using System;
	using System.Linq;
	using System.Numerics;

	public class P18_SequenceOfCommands
	{
		private const char ArgumentsDelimiter = ' ';

		public static void Main()
		{
			int sizeOfArray = int.Parse(Console.ReadLine());

			BigInteger[] array = Console.ReadLine()
				.Split(ArgumentsDelimiter)
				.Select(BigInteger.Parse)
				.ToArray();

			while (true)
			{
				string line = Console.ReadLine();
				if (line.Equals("stop"))
				{
					return;
				}

				string command = "";
				if (line.Equals("rshift"))
				{
					command = "rshift";
				}
				else if (line.Equals("lshift"))
				{
					command = "lshift";
				}
				else
				{
					int i = 0;
					while (line[i] != ' ')
					{
						command += line[i];
						i++;
					}
				}

				int[] args = new int[2];

				if (command.Equals("add") ||
					command.Equals("subtract") ||
					command.Equals("multiply"))
				{
					string[] stringParams = line.Split(ArgumentsDelimiter);
					args[0] = int.Parse(stringParams[1]);
					args[1] = int.Parse(stringParams[2]);
				}

				PerformAction(array, command, args);
				PrintArray(array);
				Console.WriteLine();
			}
		}

		static void PerformAction(BigInteger[] array, string action, int[] args)
		{
			int pos = args[0];
			int value = args[1];

			switch (action)
			{
				case "multiply":
					array[pos - 1] *= value;
					break;
				case "add":
					array[pos - 1] += value;
					break;
				case "subtract":
					array[pos - 1] -= value;
					break;
				case "lshift":
					ArrayShiftLeft(array);
					break;
				case "rshift":
					ArrayShiftRight(array);
					break;
			}
		}

		private static void ArrayShiftRight(BigInteger[] array)
		{
			BigInteger[] tempArray = array.Clone() as BigInteger[];
			tempArray[0] = array[array.Length - 1];
			for (int i = array.Length - 1; i >= 1; i--)
			{
				tempArray[i] = array[i - 1];
			}
			for (int j = 0; j < tempArray.Length; j++)
			{
				array[j] = tempArray[j];
			}
		}

		private static void ArrayShiftLeft(BigInteger[] array)
		{
			BigInteger[] tempArray = array.Clone() as BigInteger[];
			tempArray[tempArray.Length - 1] = array[0];
			for (int i = 0; i < array.Length - 1; i++)
			{
				tempArray[i] = array[i + 1];
			}
			for (int j = 0; j < tempArray.Length; j++)
			{
				array[j] = tempArray[j];
			}
		}

		private static void PrintArray(BigInteger[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
	}
}
