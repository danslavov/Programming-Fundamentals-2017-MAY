namespace P04_AverageGrades
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P04_AverageGrades
	{
		public class Student
		{
			public string Name { get; set; }
			public List<double> Grades { get; set; }
			public double AverageGrade
			{
				get
				{
					return Grades.Average();
				}
			}
		}

		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var students = CreateStudentsList(n);
			var orderedStudents = students
				.OrderBy(a => a.Name)
				.ThenByDescending(a => a.AverageGrade)
				.ToArray();

			foreach (var student in orderedStudents)
			{
				Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade);
			}
		}

		public static List<Student> CreateStudentsList(int n)
		{
			var students = new List<Student>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split();
				var name = input[0];
				var grades = input.Skip(1).Select(double.Parse).ToList();

				var newStudent = new Student()
				{
					Name = name,
					Grades = grades
				};
				if (newStudent.AverageGrade >= 5)
				{
					students.Add(newStudent);
				}
			}
			return students;
		}
	}
}
