using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_ReverseCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			char one = char.Parse(Console.ReadLine());
			char two = char.Parse(Console.ReadLine());
			char three = char.Parse(Console.ReadLine());
			char temp = one;
			one = three;
			three = temp;
			Console.WriteLine("{0}{1}{2}", one, two, three);
		}
	}
}
