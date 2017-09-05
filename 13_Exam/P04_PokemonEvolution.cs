namespace P04_PokemonEvolution
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P04_PokemonEvolution
	{
		public static void Main()
		{
			var input = Console.ReadLine();
			var pokemons = new Dictionary<string, List<Evol>>();
			while (input != "wubbalubbadubdub")
			{
				if (!pokemons.ContainsKey(input))
				{
					if (input.Contains(" -> "))
					{
						var splitInput = input.Split(" -> ".ToCharArray(),
							StringSplitOptions.RemoveEmptyEntries);
						PopulatePokemons(splitInput, pokemons);
					}
				}
				else
				{
					PrintSinglePokemon(input, pokemons);
				}
				input = Console.ReadLine();
			}
			PrintResult(pokemons);
		}

		public static void PrintResult(
			Dictionary<string, List<Evol>> pokemons)
		{
			foreach (var pok in pokemons)
			{
				Console.WriteLine("# " + pok.Key);
				foreach (var evol in pok.Value
					.OrderByDescending(e => e.Index))
				{
					Console.WriteLine($"{evol.Type} <-> {evol.Index}");
				}
			}
		}

		public static void PrintSinglePokemon(
			string input, Dictionary<string, List<Evol>> pokemons)
		{
			Console.WriteLine($"# {input}");
			foreach (var evol in pokemons[input])
			{
				Console.WriteLine($"{evol.Type} <-> {evol.Index}");
			}
		}

		public static void PopulatePokemons(
			string[] splitInput, Dictionary<string, List<Evol>> pokemons)
		{
			var name = splitInput[0];
			var type = splitInput[1];
			var index = int.Parse(splitInput[2]);
			var evolution = new Evol
			{
				Type = type, Index = index
			};
			if (!pokemons.ContainsKey(name))
			{
				pokemons[name] = new List<Evol>();
			}
			pokemons[name].Add(evolution);
		}
	}

	public class Evol
	{
		public string Type { get; set; }
		public int Index { get; set; }
	}
}