using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_IntegerToHexAndBinary
{
	class Program
	{
		static void Main(string[] args)
		{
			int numDecimal = int.Parse(Console.ReadLine());
			string numHex = Convert.ToString(numDecimal, 16).ToUpper();
			string numBinary = Convert.ToString(numDecimal, 2);
			Console.WriteLine("{0}\n{1}", numHex, numBinary);
		}
	}
}
