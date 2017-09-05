namespace P02_VehicleCatalogue
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P02_VehicleCatalogue
	{
		public static void Main()
		{
			var vehicleList = new List<Vehicle>();
			PopulateList(vehicleList);
			PrintVehicles(vehicleList);
			var carAvgHP = CalculateAvgHP(vehicleList, "Car");
			var truckAvgHP = CalculateAvgHP(vehicleList, "Truck");
			Console.WriteLine($"Cars have average horsepower of: {carAvgHP:F2}.\n" +
				$"Trucks have average horsepower of: {truckAvgHP:F2}.");
		}

		public static double CalculateAvgHP(List<Vehicle> vehicleList, string type)
		{
			if (vehicleList.Any(v => v.Type.Equals(type)))
			{
				var hPList = new List<int>();
				foreach (var vehicle in vehicleList.Where(v => v.Type == type))
				{
					hPList.Add(vehicle.HP);
				}
				return hPList.Average();
			}
			else
			{
				return 0d;
			}
		}

		public static void PrintVehicles(List<Vehicle> vehicleList)
		{
			while (true)
			{
				var model = Console.ReadLine();
				if (model == "Close the Catalogue")
				{
					break;
				}
				var index = vehicleList.FindIndex(v => v.Model == model);
				Console.WriteLine($"Type: {vehicleList[index].Type}\n" +
					$"Model: {vehicleList[index].Model}\n" +
					$"Color: {vehicleList[index].Color}\n" +
					$"Horsepower: {vehicleList[index].HP}");
			}
		}

		public static void PopulateList(List<Vehicle> vehicleList)
		{
			var input = Console.ReadLine().Split();
			while (input[0] != "End")
			{
				var type = input[0].ToLower();
				if (type == "car")
				{
					type = "Car";
				}
				else
				{
					type = "Truck";
				}
				var model = input[1];
				var color = input[2];
				var hP = int.Parse(input[3]);
				vehicleList.Add(new Vehicle
				{
					Type = type,
					Model = model,
					Color = color,
					HP = hP
				});
				input = Console.ReadLine().Split();
			}
		}
	}

	public class Vehicle
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int HP { get; set; }
	}
}
