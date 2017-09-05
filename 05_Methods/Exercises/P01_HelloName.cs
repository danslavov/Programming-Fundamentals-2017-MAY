namespace P01_HelloName
{
	using System;

	public class P01_HelloName
	{
		public static void HelloName(string name)
		{
			Console.WriteLine($"Hello, {name}!");
		}

		public static void Main()
		{
			string name = Console.ReadLine();
			HelloName(name);
		}
	}
}
