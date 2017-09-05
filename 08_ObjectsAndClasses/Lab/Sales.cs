﻿namespace P07_SalesReport
{
	public class Sale
	{
		public string Town { get; set; }
		public string Product { get; set; }
		public double Price { get; set; }
		public double Quantity { get; set; }
		public double Total
		{
			get
			{
				return Price * Quantity;
			}
		}
	}
}
