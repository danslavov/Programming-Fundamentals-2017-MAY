﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CircleArea_12DigitsPrecision
{
	class Program
	{
		static void Main(string[] args)
		{
			double radius = double.Parse(Console.ReadLine());
			double area = Math.PI * radius * radius;
			Console.WriteLine($"{area:f12}");
		}
	}
}
