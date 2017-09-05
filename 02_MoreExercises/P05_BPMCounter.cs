namespace P05_BPMCounter
{
	using System;

	public class P05_BPMCounter
	{
		public static void Main()
		{
			var frequency = int.Parse(Console.ReadLine());
			var count = int.Parse(Console.ReadLine());
			var timeInSeconds = count * 60 / frequency;
			var minutes = timeInSeconds / 60;
			var seconds = timeInSeconds % 60;
			var bars = Math.Round((count / 4.0), 1);

			Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
		}
	}
}
