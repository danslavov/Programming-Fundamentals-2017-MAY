namespace P08_SMSTyping
{
	using System;

	public class P08_SMSTyping
	{
		public static void Main()
		{
			var messageLength = int.Parse(Console.ReadLine());
			var message = String.Empty;

			for (int i = 0; i < messageLength; i++)
			{
				var button = Console.ReadLine();
				var combination = String.Empty;
				var digit = button[0] - 48;
				var length = button.Length;

				switch (digit)
				{
					case 0:
						combination = " ";
						break;
					case 2:
						combination = "abc";
						break;
					case 3:
						combination = "def";
						break;
					case 4:
						combination = "ghi";
						break;
					case 5:
						combination = "jkl";
						break;
					case 6:
						combination = "mno";
						break;
					case 7:
						combination = "pqrs";
						break;
					case 8:
						combination = "tuv";
						break;
					case 9:
						combination = "wxyz";
						break;
				}

				message += combination[length - 1];
			}

			Console.WriteLine(message);
		}
	}
}
