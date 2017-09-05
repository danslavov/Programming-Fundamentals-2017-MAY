namespace P05_BookLibrary
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Library
	{
		public string Name { get; set; }
		public List<Book> Books { get; set; }

		public Dictionary<string, decimal> GetPricesByAuthor()
		{
			var pricesByAuthor = new Dictionary<string, decimal>();

			foreach (var book in Books)
			{
				if (!pricesByAuthor.ContainsKey(book.Author))
				{
					pricesByAuthor[book.Author] = 0M;
				}
				pricesByAuthor[book.Author] += book.Price;
			}
			return pricesByAuthor;
		}
	}

	public class Book
	{
		public string Title { get; set; }			// not used for current problem
		public string Author { get; set; }
		public string Publisher { get; set; }       // not used for current problem
		public DateTime ReleaseDate { get; set; }   // not used for current problem
		public int ISBN { get; set; }               // not used for current problem
		public decimal Price { get; set; }
	}

	public class P05_BookLibrary
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var library = new Library()
			{
				Name = "FirstLibrary",
				Books = CreateBookList(n)
			};
			var result = library
				.GetPricesByAuthor()
				.OrderByDescending(x => x.Value)
				.ThenBy(x => x.Key);
			foreach (var item in result)
			{
				Console.WriteLine("{0} -> {1:F2}", item.Key, item.Value);
			}
		}

		public static Book CreateBook(string[] input)
		{
			return new Book()
			{
				Author = input[1],
				Price = decimal.Parse(input[5])
			};
		}

		public static List<Book> CreateBookList(int n)
		{
			var bookList = new List<Book>();
			for (var i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split();
				var currentBook = CreateBook(input);
				bookList.Add(currentBook);
			}
			return bookList;
		}
	}
}
