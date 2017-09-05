namespace P09_JumpAround
{
	using System;

	public class P09_JumpAround
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var numbers = new int[input.Length];
			for (var i = 0; i < input.Length; i++)
			{
				numbers[i] = int.Parse(input[i]);
			}
			var sum = numbers[0];
			var value = numbers[0];
			var index = 0;

			while (true)
			{
				if (index + value < numbers.Length)
				{
					index += value;
					value = numbers[index];
					sum += value;
				}
				else if (index - value >= 0)
				{
					index -= value;
					value = numbers[index];
					sum += value;
				}
				else
				{
					break;
				}
			}

			Console.WriteLine(sum);
		}
	}
}
