using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_EmployeeData
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			ushort age = ushort.Parse(Console.ReadLine());
			char gender = char.Parse(Console.ReadLine());
			ulong IDNumber = ulong.Parse(Console.ReadLine());
			uint employeeNumber = uint.Parse(Console.ReadLine());

			Console.WriteLine(@"First name: {0}
Last name: {1}
Age: {2}
Gender: {3}
Personal ID: {4}
Unique Employee number: {5}", firstName, lastName, age, gender, IDNumber, employeeNumber);
		}
	}
}
