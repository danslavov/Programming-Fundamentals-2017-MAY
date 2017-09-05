using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CenturiesToMinutes
{
	class Program
	{
		static void Main(string[] args)
		{
			ushort centuries = ushort.Parse(Console.ReadLine());
			short years = (short) (centuries * 100);
			int days = (int) (years * 365.2422);
			long hours = days * 24;
			ulong minutes = (ulong) (hours * 60);
			Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
		}
	}
}
