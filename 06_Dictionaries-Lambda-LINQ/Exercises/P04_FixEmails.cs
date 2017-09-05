namespace P04_FixEmails
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P04_FixEmails
	{
		public static void Main()
		{
			var listOfEmails = new Dictionary<string, string>();

			while (true)
			{
				var name = Console.ReadLine();
				var email = Console.ReadLine();

				if (name == "stop")
				{
					break;
				}

				var domainArr = email.Reverse().Take(2).ToString().Reverse();
				var domain = string.Join(string.Empty, domainArr);

				if (domain != "us" && domain != "uk")
				{
					listOfEmails[name] = email;
				}
			}

			foreach (var record in listOfEmails)
			{
				Console.WriteLine(record.Key + " -> " + record.Value);
			}
		}
	}
}
