namespace P05_BombNumbers
{
	using System;
	using System.Collections.Generic;

	public class P05_BombNumbers
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split(' ');
			var inputBomb = Console.ReadLine().Split(' ');
			var bomb = int.Parse(inputBomb[0]);
			var power = int.Parse(inputBomb[1]);

			var numbers = new List<int>();
			foreach (var number in input)
			{
				numbers.Add(int.Parse(number));
			}

			while (numbers.Contains(bomb))
			{
				var startIndex = numbers.IndexOf(bomb);
				var index = startIndex - power;

				for (var i = 0; (i < 2 * power + 1) && (index < numbers.Count); i++)
				{
					if (index < 0)
					{
						index++;
						continue;
					}
					else
					{
						numbers.RemoveAt(index);
					}
				}
			}

			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}
			Console.WriteLine(sum);
		}
	}
}
