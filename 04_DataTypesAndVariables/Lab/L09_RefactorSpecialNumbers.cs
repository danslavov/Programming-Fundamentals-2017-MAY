using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RefactorSpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int range = int.Parse(Console.ReadLine());
			for (int number = 1; number <= range; number++)
			{
				int curNumber = number;
				int sum = 0;
				while (curNumber > 0)
				{
					sum += curNumber % 10;
					curNumber = curNumber / 10;
				}
				bool special = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine($"{number} -> {special}");
			}

		}
	}
}
