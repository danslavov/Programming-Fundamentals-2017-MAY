namespace P04_WinningTicket
{
	using System;

	public class P04_WinningTicket
	{
		public static void Main()
		{
			var tickets = Console.ReadLine()
				.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			foreach (var ticket in tickets)
			{
				if (ticket.Length == 20)
				{
					CheckTicket(ticket);
				}
				else
				{
					Console.WriteLine("invalid ticket");
				}
			}
		}

		public static void CheckTicket(string ticket)
		{
			var left = ticket.Substring(0, 10);
			var right = ticket.Substring(10);
			var winningSymbols = new char[] { '@', '#', '$', '^' };
			var noMatch = true;
			foreach (var symbol in winningSymbols)
			{
				var leftLength = CalculateLength(left, symbol);
				var rightLength = CalculateLength(right, symbol);
				if (leftLength >= 6 && rightLength >= 6)
				{
					noMatch = false;
					PrintMatchingResult(ticket, symbol, Math.Min(leftLength, rightLength));
					return;
				}
			}
			if (noMatch)
			{
				Console.WriteLine($"ticket \"{ticket}\" - no match");
			}
		}

		public static void PrintMatchingResult(string ticket, char symbol, int length)
		{
			if (length < 10)
			{
				Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
			}
			else
			{
				Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol} Jackpot!");
			}
		}

		public static int CalculateLength(string half, char symbol)
		{
			var winningLength = 0;
			var symbolPosition = half.IndexOf(symbol);
			if (symbolPosition != -1)
			{
				for (int i = symbolPosition; i < half.Length; i++)
				{
					if (half[i] == symbol)
					{
						winningLength++;
					}
					else
					{
						break;
					}
				}
			}
			return winningLength;
		}
	}
}
