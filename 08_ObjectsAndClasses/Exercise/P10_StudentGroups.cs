namespace P10_StudentGroups
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Globalization;

	public class P10_StudentGroups
	{
		public static void Main()
		{
			var townList = new List<Town>();
			var input = Console.ReadLine();
			while (input != "End")
			{
				CreateTown(input, townList);
				input = Console.ReadLine();
				while (!input.Contains("=>") && input != "End")
				{
					var newStudent = CreateStudent(input);

					// add new student to the list of students in the last element of townList
					townList[townList.Count - 1].Students.Add(newStudent);

					input = Console.ReadLine();
				}
			}
			GenerateResult(townList);
		}

		public static void CreateTown(string input, List<Town> townList)
		{
			var townAndCapacity = input.Split(new char[] { '=', '>' },
					StringSplitOptions.RemoveEmptyEntries);
			var townName = townAndCapacity[0].Trim();

			var temp = townAndCapacity[1].Split(
				new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var seats = int.Parse(temp[0]);

			townList.Add(
				new Town
				{
					Name = townName,
					Seats = seats,
					Students = new List<Student>()
				});
		}

		public static Student CreateStudent(string input)
		{
			var studentData = input.Split('|');
			var studentName = studentData[0].Trim();
			var email = studentData[1].Trim();
			var registrationDate = DateTime.ParseExact(
				studentData[2].Trim(), "d-MMM-yyyy",
				CultureInfo.InstalledUICulture);
			return new Student
			{
				Name = studentName,
				Email = email,
				RegistrationDate = registrationDate
			};
		}

		public static void GenerateResult(List<Town> townList)
		{
			PrintGroupAndTownCounts(townList);

			foreach (var town in townList.OrderBy(t => t.Name))
			{
				var studentCount = town.Students.Count;
				var groupCount = (int)Math.Ceiling(studentCount / (double)town.Seats);
				PrintGroups(town, groupCount);
			}
		}

		public static void PrintGroupAndTownCounts(List<Town> townList)
		{
			var townCount = townList.Count;
			var totalgroupCount = 0;
			foreach (var town in townList)
			{
				var studentCount = town.Students.Count;
				totalgroupCount += (int)Math.Ceiling(studentCount / (double)town.Seats);
			}
			Console.WriteLine($"Created {totalgroupCount} groups in {townCount} towns:");
		}

		public static List<string> CreateEmailList(Town town)
		{
			var emailList = new List<string>();
			foreach (var student in town.Students
								.OrderBy(s => s.RegistrationDate)
								.ThenBy(s => s.Name)
								.ThenBy(s => s.Email))
			{
				emailList.Add(student.Email);
			}
			return emailList;
		}

		public static void PrintGroups(Town town, int groupCount)
		{
			var studentsToTake = town.Seats;

			for (int i = 0; i < groupCount; i++)
			{
				var studentsToSkip = i * town.Seats;
				var emailsToPrint = CreateEmailList(town)
					.Skip(studentsToSkip).Take(studentsToTake);

				Console.WriteLine($"{town.Name} => " +
					$"{string.Join(", ", emailsToPrint)}");
			}
		}
	}

	public class Student
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime RegistrationDate { get; set; }
	}

	public class Town
	{
		public string Name { get; set; }
		public int Seats { get; set; }
		public List<Student> Students { get; set; }
	}


}
