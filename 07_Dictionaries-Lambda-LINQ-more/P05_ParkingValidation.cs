namespace P05_ParkingValidation
{
	using System;
	using System.Collections.Generic;

	public class P05_ParkingValidation
	{
		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var dataBase = new Dictionary<string, string>();
			
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split();
				var command = input[0].ToLower();
				var user = input[1];

				if (command == "unregister")
				{
					Unregister(dataBase, user);
				}

				else if (command == "register")
				{
					var plate = input[2];
					Register(dataBase, user, plate);
				}
			}

			foreach (var item in dataBase)
			{
				Console.WriteLine(item.Key + " => " + item.Value);
			}
		}

		public static void Register(Dictionary<string, string> dataBase, string user, string plate)
		{
			// if a user tries to register another license plate,
			// using the same username:

			if (dataBase.ContainsKey(user) && (dataBase[user] != plate))
			{
				Console.WriteLine($"ERROR: already registered " +
					$"with plate number {dataBase[user]}");
					return;
			}

			// if the license plate is invalid:

			if (!CheckIfValid(plate))
			{
				Console.WriteLine($"ERROR: invalid license plate {plate}");
				return;
			}

			// if the user tries to register someone else's license plate:

			foreach (var item in dataBase)
			{
				if (item.Key != user && item.Value == plate)
				{
					Console.WriteLine($"ERROR: license plate {plate} is busy");
					return;
				}
			}
			
			// if checks pass successfully:

			dataBase[user] = plate;
			Console.WriteLine($"{user} registered {plate} successfully");
		}

		public static void Unregister(Dictionary<string, string> dataBase, string user)
		{
			if (!dataBase.ContainsKey(user))
			{
				Console.WriteLine($"ERROR: user {user} not found");
			}
			else
			{
				dataBase.Remove(user);
				Console.WriteLine($"user {user} unregistered successfully");
			}
		}

		public static bool CheckIfValid(string plate)
		{
			// check plate length:

			if (plate.Length != 8)
			{
				return false;
			}

			// check plate letters:

			var plateLetters = new char[]
			{
				plate[0],
				plate[1],
				plate[6],
				plate[7],
			};
			
			foreach (var letter in plateLetters)
			{
				if (letter < 65 || letter > 90)
				{
					return false;
				}
			}
			
			// check plate digits:

			for (int i = 2; i < 6; i++)
			{
				if (plate[i] < 48 || plate[i] > 57)
				{
					return false;
				}
			}

			return true;
		}
	}
}
