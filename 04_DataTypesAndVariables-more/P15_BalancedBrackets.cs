namespace P15_BalancedBrackets
{
	using System;

	public class P15_BalancedBrackets
	{
		public static void Main()
		{
			var n = byte.Parse(Console.ReadLine());
			var hasOpeningBracket = false;
			var isUnbalanced = false;

			for (byte i = 0; i < n; i++)
			{
				var input = Console.ReadLine();

				if (input == "(")
				{
					if (hasOpeningBracket)
					{
						Console.WriteLine("UNBALANCED");
						return;
					}

					hasOpeningBracket = true;
					isUnbalanced = true;
				}

				if (input == ")")
				{
					if (!hasOpeningBracket)
					{
						Console.WriteLine("UNBALANCED");
						return;
					}

					hasOpeningBracket = false;
					isUnbalanced = false;
				}
			}

			Console.WriteLine(isUnbalanced ? "UNBALANCED" : "BALANCED");
		}
	}
}
