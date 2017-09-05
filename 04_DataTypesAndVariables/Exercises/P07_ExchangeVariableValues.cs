using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_ExchangeVariableValues
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);    //Console.WriteLine("Before:\na = {0}\nb = {1}", b, a);
			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
		}
	}
}
