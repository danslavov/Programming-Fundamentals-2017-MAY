namespace P05_HandsOfCards
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P05_HandsOfCards
	{
		public static void Main()
		{
			var players = new Dictionary<string, List<string>>();

			while (true)
			{
				var input = Console.ReadLine().Split(':');
				var playerName = input[0];

				if (playerName == "JOKER")
				{
					break;
				}

				var cardList = input[1]
					.Split(new char[] { ' ', ',' }		// .Split(", ".ToCharArray()
					, StringSplitOptions.RemoveEmptyEntries)
					.ToList();

				if (!players.ContainsKey(playerName))
				{
					players[playerName] = new List<string>();
				}

				foreach (var cardPair in cardList)
				{
					if (!players[playerName].Contains(cardPair))
					{
						players[playerName].Add(cardPair);
					}
				}
			}

			foreach (var name in players)
			{
				var cardPower = 0;
				var cardType = 0;
				var totalValue = 0;

				foreach (var cardPair in name.Value)
				{
					cardPower = cardPair[0] - 48;

					if (cardPower < 2 || cardPower > 9)
					{
						switch (cardPair[0])
						{
							case '1':
								cardPower = 10;
								break;
							case 'J':
								cardPower = 11;
								break;
							case 'Q':
								cardPower = 12;
								break;
							case 'K':
								cardPower = 13;
								break;
							case 'A':
								cardPower = 14;
								break;
						}
					}

					switch (cardPair[cardPair.Length - 1])
					{
						case 'C':
							cardType = 1;
							break;
						case 'D':
							cardType = 2;
							break;
						case 'H':
							cardType = 3;
							break;
						case 'S':
							cardType = 4;
							break;
					}

					totalValue += cardPower * cardType;
				}

				Console.WriteLine(name.Key + ": " + totalValue);
			}
		}
	}
}
