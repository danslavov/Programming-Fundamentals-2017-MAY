using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P10_CenturiesToNanoseconds
{
	class Program
	{
		static void Main(string[] args)
		{
			ushort centuries = ushort.Parse(Console.ReadLine());
			int years = 100 * centuries;
			int days = (int) (years * 365.2422);
			long hours = days * 24;
			long minutes = hours * 60;
			long seconds = minutes * 60;
			long milliseconds = seconds * 1000;
			BigInteger microseconds = milliseconds * 1000;
			BigInteger nanoseconds = (microseconds * 1000);
			Console.WriteLine($"{centuries} centuries = {years} years = {days} days" +
				$" = {hours} hours = {minutes} minutes = {seconds} seconds" +
	$" = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
		}
	}
}
