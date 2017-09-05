namespace P02_ArrayManipulator
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P02_ArrayManipulator
	{
		public static void Main()
		{
			var arr = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			var command = Console.ReadLine().Split();
			while (command[0] != "end")
			{
				var operation = command[0];
				switch (operation)
				{
					case "exchange":
						var index = int.Parse(command[1]);
						Exchange(arr, index);
						break;
					case "max":
					case "min":
						MaxMin(arr, command);
						break;
					case "first":
					case "last":
						FirstLast(arr, command);
						break;
				}
				command = Console.ReadLine().Split();
			}
			Console.WriteLine($"[{string.Join(", ", arr)}]");
		}

		public static void FirstLast(int[] arr, string[] command)
		{
			if (int.Parse(command[1]) <= arr.Length)
			{
				var side = command[0];
				var count = int.Parse(command[1]);
				var evenOdd = (command[2] == "even") ? 0 : 1;
				var result = new List<int>();
				if (side == "first")
				{
					result = PopulateResultStraight(arr, command, count, evenOdd, result);
				}
				else
				{
					result = PopulateResultReverse(
						arr, command, count, evenOdd, result);
				}
				Console.WriteLine($"[{string.Join(", ", result)}]");
			}
			else
			{
				Console.WriteLine("Invalid count");
			}
		}

		public static List<int> PopulateResultReverse(int[] arr, string[] command, int count, int evenOdd, List<int> result)
		{
			for (int i = arr.Length - 1; i >= 0; i--)
			{
				if (arr[i] % 2 == evenOdd)
				{
					result.Add(arr[i]);
					count--;
					if (count == 0)
					{
						break;
					}
				}
			}
			result.Reverse();
			return result;
		}

		public static List<int> PopulateResultStraight(
			int[] arr, string[] command, int count, int evenOdd, List<int> result)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == evenOdd)
				{
					result.Add(arr[i]);
					count--;
					if (count == 0)
					{
						break;
					}
				}
			}
			return result;
		}

		public static void MaxMin(int[] arr, string[] command)
		{
			var operation = command[0];
			var oddEven = command[1];
			if (operation == "min")
			{
				if (oddEven == "odd")
				{
					PrintMin(arr, 1);
				}
				else
				{
					PrintMin(arr, 0);
				}
			}
			else
			{
				if (oddEven == "odd")
				{
					PrintMax(arr, 1);
				}
				else
				{
					PrintMax(arr, 0);
				}
			}
		}

		public static void PrintMin(int[] arr, int evenOdd)
		{
			var resultValue = int.MaxValue;
			var resultIndex = -1;
			for (var i = 0; i < arr.Length; i++)
			{
				if ((arr[i] % 2 == evenOdd) && (arr[i] <= resultValue))
				{

					resultValue = arr[i];
					resultIndex = i;
				}
			}
			Console.WriteLine(
				(resultIndex >= 0) ? $"{resultIndex}" : "No matches");
		}

		public static void PrintMax(int[] arr, int evenOdd)
		{
			var resultValue = int.MinValue;
			var resultIndex = -1;
			for (var i = 0; i < arr.Length; i++)
			{
				if ((arr[i] % 2 == evenOdd) && (arr[i] >= resultValue))
				{

					resultValue = arr[i];
					resultIndex = i;
				}
			}
			Console.WriteLine(
				(resultIndex >= 0) ? $"{resultIndex}" : "No matches");
		}

		public static void Exchange(int[] arr, int index)
		{
			if (index < 0 || index > arr.Length - 1)
			{
				Console.WriteLine("Invalid index");
				return;
			}
			var newArr = new int[arr.Length];
			for (int i = 0; i < newArr.Length; i++)
			{
				newArr[i] = arr[(index + i + 1) % arr.Length];
			}
			newArr.CopyTo(arr, 0);
		}
	}
}
