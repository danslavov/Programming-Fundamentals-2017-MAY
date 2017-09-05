namespace P02_AdvertisementMessage
{
	using System;

	public class P02_AdvertisementMessage
	{
		public static void Main()
		{
			var phrases = new string[]
			{
				"Excellent product.",
				"Exceptional product.",
				"Such a great product.",
				"I always use that product.",
				"Best product of its category.",
				"I can’t live without this product."
			};
			var events = new string[]
			{
				"I feel great!",
				"Now I feel good.",
				"I have succeeded with this product.",
				"Try it yourself, I am very satisfied.",
				"I cannot believe but now I feel awesome.",
				"Makes miracles. I am happy of the results!"
			};
			var authors = new string[]
				{
					"Diana", "Petya", "Stella",
					"Elena","Katya", "Iva", "Annie", "Eva"
				};
			var cities = new string[]
				{
					"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
				};

			var rnd = new Random();
			var n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				var phraseIndex = rnd.Next(phrases.Length);
				var eventIndex = rnd.Next(events.Length);
				var authorIndex = rnd.Next(authors.Length);
				var cityIndex = rnd.Next(cities.Length);
				Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} " +
					$"{authors[authorIndex]} – {cities[cityIndex]}");
			}
		}
	}
}
