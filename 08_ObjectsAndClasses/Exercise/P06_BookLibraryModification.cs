namespace P06_BookLibraryModification
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Globalization;

	public class Library
	{
		public string Name { get; set; }
		public List<Book> Books { get; set; }

		public Dictionary<string, decimal> GetPricesByAuthor()     // not used for current problem
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

		public Dictionary<string, DateTime> GetTitlesByDate()
		{
			var titlesByDate = new Dictionary<string, DateTime>();

			foreach (var book in Books)
			{
				titlesByDate[book.Title] = book.ReleaseDate;
			}
			return titlesByDate;
		}
	}

	public class Book
	{
		public string Title { get; set; }           
		public string Author { get; set; }          // not used for current problem
		public string Publisher { get; set; }       // not used for current problem
		public DateTime ReleaseDate { get; set; }   
		public int ISBN { get; set; }               // not used for current problem
		public decimal Price { get; set; }          // not used for current problem
	}

	public class P06_BookLibraryModification
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var library = new Library()
			{
				Name = "FirstLibrary",
				Books = CreateBookList(n)
			};
			var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",
				CultureInfo.InvariantCulture);
			var result = library
				.GetTitlesByDate()
				.Where(x => x.Value > date)
				.OrderBy(x => x.Value)
				.ThenBy(x => x.Key)
				.ToDictionary(pair => pair.Key, pair => pair.Value);

			foreach (var item in result)
			{
				Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Key, item.Value);
			}
		}

		public static Book CreateBook(string[] input)
		{
			return new Book()
			{
				Title = input[0],
				Author = input[1],
				ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy",
				CultureInfo.InvariantCulture),
				Price = decimal.Parse(input[5]),

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
