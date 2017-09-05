using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_FastPrimeChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			int range = int.Parse(Console.ReadLine());
			for (int curNum = 2; curNum <= range; curNum++)
			{
				bool prime = true;
				for (int divider = 2; divider <= Math.Sqrt(curNum); divider++)
				{
					if (curNum % divider == 0)
					{
						prime = false;
						break;
					}
				}
				Console.WriteLine($"{curNum} -> {prime}");
			}
		}
	}
}
