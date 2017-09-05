namespace P01_Phonebook
{
	using System;
	using System.Collections.Generic;

	public class P01_Phonebook
	{
		public static void Main()
		{
			string command;
			var phonebook = new Dictionary<string, string>();

			do
			{
				var input = Console.ReadLine().Split(' ');
				command = input[0].ToLower();

				if (command == "a")
				{
					Add(phonebook, input[1], input[2]);
				}
				else if (command == "s")
				{
					Search(phonebook, input[1]);
				}
			}

			while (command != "end");

		}

		public static void Add
			(Dictionary<string, string> phonebook, string name, string number)
		{
			phonebook[name] = number;
		}

		public static void Search
			(Dictionary<string, string> phonebook, string name)
		{
			if (phonebook.ContainsKey(name))
			{
				Console.WriteLine(name + " -> " + phonebook[name]);
			}
			else
			{
				Console.WriteLine($"Contact {name} does not exist.");
			}
		}
	}
}
