using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_PrintPartOfASCIITable
{
	class Program
	{
		static void Main(string[] args)
		{
			byte start = byte.Parse(Console.ReadLine());
			byte end = byte.Parse(Console.ReadLine());
			for (byte i = start; i <= end; i++)
			{
				Console.Write((char)i + " ");
			}
			Console.WriteLine();
		}
	}
}
