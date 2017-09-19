namespace P01_ExtractEmails
{
	using System;
	using System.Text.RegularExpressions;

	public class P01_ExtractEmails
	{
		public static void Main(string[] args)
		{
			var regex = new Regex(@"(^|(?<=\s))[0-9A-Za-z]+[\w\-\.]*[0-9A-Za-z]+@[A-Za-z]+(\-[A-Za-z]+)?(\.[A-Za-z]+)+");
			var matches = regex.Matches(Console.ReadLine());
			foreach  (Match m in matches)
			{
				Console.WriteLine(m);
			}
		}
	}
}
