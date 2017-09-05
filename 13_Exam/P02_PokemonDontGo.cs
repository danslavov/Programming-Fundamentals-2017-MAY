namespace P02_PokemonDontGo
{
	using System;
	using System.Linq;

	public class P02_PokemonDontGo
	{
		public static void Main()
		{
			var pokemons = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(long.Parse)
				.ToList();
			var sum = 0L;
			while (pokemons.Count > 0)
			{
				var index = int.Parse(Console.ReadLine());
				var value = 0L;
				if (index < 0)
				{
					value = pokemons.First();
					pokemons.RemoveAt(0);
					pokemons.Insert(0, pokemons.Last());
				}
				else if (index > pokemons.Count - 1)
				{
					value = pokemons.Last();
					pokemons.RemoveAt(pokemons.Count - 1);
					pokemons.Add(pokemons.First());
				}
				else
				{
					value = pokemons[index];
					pokemons.RemoveAt(index);
				}
				sum += value;
				pokemons = pokemons
						.Select(p => p <= value ? p += value : p -= value)
						.ToList();
			}
			Console.WriteLine(sum);
		}
	}
}
