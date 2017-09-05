namespace P08_MentorGroup
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Globalization;

	public class P08_MentorGroup
	{
		public class User
		{
			public string Name { get; set; }
			public List<DateTime> Dates { get; set; }
			public List<string> Comments { get; set; }
		}

		public static void Main()
		{
			var userList = new List<User>();
			PopulateNameAndDates(userList);
			PopulateComments(userList);
			userList = OrderList(userList);
			GenerateReport(userList);
		}

		public static void PopulateNameAndDates(List<User> userList)
		{
			var input = Console.ReadLine();
			while (input != "end of dates")
			{
				var nameAndDates = input.Split(' ', ',');
				var name = nameAndDates[0];
				var dateList = new List<DateTime>();
				for (int i = 1; i < nameAndDates.Length; i++)
				{
					dateList.Add(DateTime.ParseExact(nameAndDates[i], "dd/MM/yyyy",
						CultureInfo.InvariantCulture));
				}

				var existingUser = userList.FindIndex(u => u.Name == name);
				if (existingUser < 0)
				{
					userList.Add(new User
					{
						Name = name,
						Dates = dateList,
						Comments = new List<string>()
					});
				}
				else
				{
					userList[existingUser].Dates.AddRange(dateList);
				}
				input = Console.ReadLine();
			}
		}

		public static void PopulateComments(List<User> userList)
		{
			var input = Console.ReadLine();
			while (input != "end of comments")
			{
				var nameAndComment = input.Split('-');
				var name = nameAndComment[0];
				var comment = nameAndComment[1];
				var existingUser = userList.FindIndex(com => com.Name == name);
				if (existingUser >= 0)
				{
					userList[existingUser].Comments.Add(comment);
				}
				input = Console.ReadLine();
			}
		}

		public static List<User> OrderList(List<User> userList)
		{
			userList = userList.OrderBy(u => u.Name).ToList();
			foreach (var user in userList)
			{
				user.Dates = user.Dates.OrderBy(d => d).ToList();
			}
			return userList;
		}

		public static void GenerateReport(List<User> userList)
		{
			foreach (var user in userList)
			{
				Console.WriteLine($"{user.Name}\nComments:");
				foreach (var comment in user.Comments)
				{
					Console.WriteLine($"- {comment}");
				}
				Console.WriteLine("Dates attended:");
				foreach (var date in user.Dates)
				{
					Console.WriteLine($"-- {date:dd/MM/yyyy}");
				}
			}
		}
	}
}
