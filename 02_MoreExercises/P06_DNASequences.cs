namespace P06_DNASequences
{
	using System;

	public class P06_DNASequences
	{
		public static void Main()
		{
			var match = int.Parse(Console.ReadLine());
			var sequence = String.Empty;
			var bases = new string[]
			{
				"A", "C", "G", "T"
			};
			var newLine = 0;

			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					for (int k = 0; k < 4; k++)
					{
						var sum = i + j + k + 3;

						sequence = bases[i] + bases[j] + bases[k];

						if (sum >= match)
						{
							sequence = "O" + sequence + "O";
						}
						else
						{
							sequence = "X" + sequence + "X";
						}

						newLine++;

						if (newLine % 4 != 0)
						{
							Console.Write(sequence + " ");
						}
						else
						{
							Console.WriteLine(sequence);
						}
					}
				}
			}
		}
	}
}
