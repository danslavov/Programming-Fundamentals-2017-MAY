using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int totalPeople = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());
			double elevatorCicles = (double) totalPeople / capacity;
			Console.WriteLine(Math.Ceiling(elevatorCicles));
		}
	}
}
