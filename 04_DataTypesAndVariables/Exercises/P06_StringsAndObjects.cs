using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_StringsAndObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			string hello = "Hello";
			string world = "World";
			Object helloWorld = hello + " " + world;
			string final = (string)helloWorld;
			Console.WriteLine(final);
		}
	}
}
