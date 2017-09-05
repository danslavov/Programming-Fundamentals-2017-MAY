using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_BooleanVariable
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			Console.WriteLine(Convert.ToBoolean(text) ? "Yes" : "No");
		}
	}
}
