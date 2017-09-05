using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_TheaThePhotographer
{
	class Program
	{
		static void Main(string[] args)
		{
			long totalNumber = long.Parse(Console.ReadLine());
			long filterTime = long.Parse(Console.ReadLine());
			long filterFactor = long.Parse(Console.ReadLine());
			long uploadTime = long.Parse(Console.ReadLine());
			long totalTime = 0;

			long filteredNumber = (long)Math.Ceiling((double)totalNumber * filterFactor / 100);
			totalTime += (totalNumber * filterTime) + (filteredNumber * uploadTime);

			//---- but doesn't work when inputs are too big:
			//
			//TimeSpan formattedTime = new TimeSpan(0, 0, (int)totalTime);
			//Console.WriteLine(formattedTime.ToString(@"d\:hh\:mm\:ss"));

			long seconds = 0;
			long days = totalTime / 86400;
			seconds += totalTime % 86400;
			long hours = seconds / 3600;
			seconds %= 3600;
			long minutes = seconds / 60;
			seconds %= 60;

			Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, seconds);

		}
	}
}
