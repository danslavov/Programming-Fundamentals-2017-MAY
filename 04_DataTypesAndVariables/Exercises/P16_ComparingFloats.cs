using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_ComparingFloats
{
	class Program
	{
		static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			bool equal = Math.Abs(a - b) < 0.000001;
			Console.WriteLine(equal);
		}
	}
}
