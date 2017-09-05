using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_VowelOrDigit
{
	class Program
	{
		static void Main(string[] args)
		{
			char symbol = char.Parse(Console.ReadLine());

			switch ((int)symbol)
			{
				case 65:
				case 69:
				case 73:
				case 79:
				case 85:
				case 87:                          //'W'
				case 97:
				case 101:
				case 105:
				case 111:
				case 117:
				case 119:                        //'w'
					Console.WriteLine("vowel");
					return;
			}

			if (symbol > 47 && symbol < 58)
			{
				Console.WriteLine("digit");
			}
			else
			{
				Console.WriteLine("other");
			}
		}
	}
}
