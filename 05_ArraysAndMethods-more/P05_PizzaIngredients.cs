namespace P05_PizzaIngredients
{
	using System;
	using System.Collections.Generic;

	public class P05_PizzaIngredients
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var exactLength = int.Parse(Console.ReadLine());
			var ingredients = new string[input.Length];
			for (var i = 0; i < ingredients.Length; i++)
			{
				ingredients[i] = input[i];
			}
			var usedIngredients = new List<string>();

			foreach (var item in ingredients)
			{
				if (item.Length == exactLength)
				{
					Console.WriteLine($"Adding {item}.");
					usedIngredients.Add(item);

					if (usedIngredients.Count == 10)
					{
						break;
					}
				}
			}

			Console.WriteLine($"Made pizza with total of " +
				$"{usedIngredients.Count} ingredients.");
			Console.Write("The ingredients are: ");
			Console.WriteLine(string.Join(", ", usedIngredients) + ".");
		}
	}
}
