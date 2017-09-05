namespace P14_MagicLetter
{
	using System;
	using System.Text;

	public class P14_MagicLetter
	{
		public static void Main()
		{
			var firstLetter = char.Parse(Console.ReadLine());
			var lastLetter = char.Parse(Console.ReadLine());
			var skiptLetter = char.Parse(Console.ReadLine());
			var resultString = String.Empty;
			StringBuilder sb = new System.Text.StringBuilder();

			for (char i = firstLetter; i <= lastLetter; i++)
			{
				for (char j = firstLetter; j <= lastLetter; j++)
				{
					for (char k = firstLetter; k <= lastLetter; k++)
					{
						if (i != skiptLetter && j != skiptLetter 
							&& k != skiptLetter)
						{
							sb.Append(resultString)
								.Append(i).Append(j).Append(k)
								.Append(' '); 
						}
					}
				}
			}

			Console.WriteLine(sb);
		}
	}
}
