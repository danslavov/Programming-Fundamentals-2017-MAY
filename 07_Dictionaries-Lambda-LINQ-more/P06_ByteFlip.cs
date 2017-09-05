namespace P06_ByteFlip
{
	using System;
	using System.Linq;

	public class P06_ByteFlip
	{
		public static void Main()
		{
			var bytes = Console.ReadLine()
				.Split()
				.Where(x => x.Length == 2)
				.ToArray();
			ReverseElements(bytes);
			ReverseArray(bytes);
			PrintResult(bytes);
		}
		
		public static void ReverseElements(string[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				var word = arr[i];
				var newWord = String.Empty;
				newWord += word[1];
				newWord += word[0];
				arr[i] = newWord;
			}
		}

		public static void ReverseArray(string[] arr)
		{
			for (int i = 0; i < arr.Length / 2; i++)
			{
				var temp = arr[i];
				arr[i] = arr[arr.Length - 1 - i];
				arr[arr.Length - 1 - i] = temp;
			}
		}

		public static void PrintResult(string[] arr)
		{
			foreach (var word in arr)
			{
				Console.Write((char)Convert.ToInt32(word, 16));
			}
			Console.WriteLine();
		}
	}
}
