using System;

namespace PizzaApplication
{
	public class Pizza
	{
		public Pizza(string name, string content, string price, string weight, string image)
		{
			Name = name;
			Content = content;
			Price = price;
			Weight = weight;
		}
		public string Name{ get; set; } 
		public string Content{ get; set; } 
		public string Price{ get; set; } 
		public string Weight{ get; set; }
		public string PizzaImage{ get; set; }
	}
}

