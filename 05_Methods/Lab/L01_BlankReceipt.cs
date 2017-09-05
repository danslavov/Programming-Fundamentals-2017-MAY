namespace P01_BlankReceipt
{
	class P01_BlankReceipt
	{
		public static void Header()
		{
			System.Console.WriteLine(@"CASH RECEIPT
------------------------------");
		}

		public static void Body()
		{
			System.Console.WriteLine(@"Charged to____________________
Received by___________________");
		}

		public static void Footer()
		{
			System.Console.WriteLine(@"------------------------------
© SoftUni
");
		}

		public static void BlankReceipt()
		{
			Header();
			Body();
			Footer();
		}

		public static void Main(string[] args)
		{
			BlankReceipt();
		}
	}
}
