namespace L06_ReplaceTag
{
	using System;
	using System.Text.RegularExpressions;

	public class L06_ReplaceTag
	{
		public static void Main(string[] args)
		{			
			var input = Console.ReadLine();
			while (input != "end")
			{
				var pattern = @"<a.*?href=(.*?)>(.*?)<\/a>";
				var evaluator = @"[URL href=$1]$2[/URL]";
				var result = Regex.Replace(input, pattern, evaluator);
				Console.WriteLine(result);
				input = Console.ReadLine();
			}
		}
	}
}
