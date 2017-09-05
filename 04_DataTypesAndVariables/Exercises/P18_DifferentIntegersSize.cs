using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P18_DifferentIntegersSize
{
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger n = BigInteger.Parse(Console.ReadLine());
			
			if (n < -9223372036854775808 || n > 9223372036854775807)
			{
				Console.WriteLine("{0} can't fit in any type", n);
			}

			else
			{
				Console.WriteLine("{0} can fit in:", n);

				if (n >= -128 && n <= 127)
				{
					Console.WriteLine("* sbyte");
				}
				if (n >= 0 && n <= 255)
				{
					Console.WriteLine("* byte");
				}
				if (n >= -32768 && n <= 32767)
				{
					Console.WriteLine("* short");
				}
				if (n >= 0 && n <= 65535)
				{
					Console.WriteLine("* ushort");
				}
				if (n >= -2147483648 && n <= 2147483647)
				{
					Console.WriteLine("* int");
				}
				if (n >= 0 && n <= 4294967295)
				{
					Console.WriteLine("* uint");
				}
				if (n >= -9223372036854775808 && n <= 9223372036854775807)
				{
					Console.WriteLine("* long");
				}
			}
		}
	}
}
