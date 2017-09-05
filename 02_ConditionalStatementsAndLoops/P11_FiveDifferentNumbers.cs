namespace P11_FiveDifferentNumbers
{
	using System;

	public class P11_FiveDifferentNumbers
	{
		public static void Main()
		{
			var startNumber = int.Parse(Console.ReadLine());
			var endNumber = int.Parse(Console.ReadLine());
			if (endNumber - startNumber >= 4)
			{
				for (int i = startNumber; i <= endNumber - 4; i++)
				{
					for (int j = i + 1; j <= endNumber - 3; j++)
					{
						for (int k = j + 1; k <= endNumber - 2; k++)
						{
							for (int l = k + 1; l <= endNumber - 1; l++)
							{
								for (int m = l + 1; m <= endNumber; m++)
								{
									Console.WriteLine($"{i} {j} {k} {l} {m}");
								}
							}

						}
					}
				}
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
