namespace P01_OrderByAge
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P01_OrderByAge
	{
		public static void Main()
		{
			var personList = new List<Person>();
			PopulateList(personList);
			foreach (var person in personList.OrderBy(p => p.Age))
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}
		}

		public static void PopulateList(List<Person> personList)
		{
			var input = Console.ReadLine().Split();
			while (input[0] != "End")
			{
				var name = input[0];
				var ID = input[1];
				var age = int.Parse(input[2]);
				personList.Add(
					new Person
					{
						Name = name,
						ID = ID,
						Age = age
					});
				input = Console.ReadLine().Split();
			}
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public string ID { get; set; }
		public int Age { get; set; }
	}
}
