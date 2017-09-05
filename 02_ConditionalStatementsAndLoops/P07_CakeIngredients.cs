namespace P07_CakeIngredients
{
	using System;

	public class P07_CakeIngredients
	{
		public static void Main()
		{
			var ingredient = Console.ReadLine();
			var numberOfIngredients = 0;

			do
			{
				Console.WriteLine($"Adding ingredient {ingredient}.");
				numberOfIngredients++;
				ingredient = Console.ReadLine();
			}

			while (ingredient != "Bake!");

			Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
		}
	}
}
