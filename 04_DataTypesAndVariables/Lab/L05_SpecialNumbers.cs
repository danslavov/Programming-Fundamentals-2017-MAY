using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				int sum = 0;
				int curNum = i;
				while (curNum > 0)
				{
					sum += curNum % 10;
					curNum /= 10;
				}
				bool special = (sum == 5 || sum == 7 || sum == 11);
				Console.WriteLine("{0} -> {1}", i, special);
			}
		}
	}
}
