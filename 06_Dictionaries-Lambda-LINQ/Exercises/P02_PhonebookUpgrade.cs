namespace P02_PhonebookUpgrade
{
	using System;
	using System.Collections.Generic;

	public class P02_PhonebookUpgrade
	{
		public static void Main()
		{
			string command;
			var phonebook = new SortedDictionary<string, string>();

			do
			{
				var input = Console.ReadLine().Split(' ');
				command = input[0].ToLower();

				if (command == "a")
				{
					phonebook[input[1]] = input[2];
				}
				else if (command == "s")
				{
					Search(phonebook, input[1]);
				}
				else if (command == "listall")
				{
					foreach (var item in phonebook)
					{
						Console.WriteLine(item.Key + " -> " + item.Value);
					}
				}
			}

			while (command != "end");
		}

		public static void Search
			(SortedDictionary<string, string> phonebook, string name)
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
