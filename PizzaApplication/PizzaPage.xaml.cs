using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using System.Reflection;

using Xamarin.Forms;

namespace PizzaApplication
{
	public partial class PizzaPage : ContentPage
	{
		List<Pizza> Pizzas;
		public PizzaPage ()
		{
			Pizzas = new List<Pizza>();
			var img = new Image{ Aspect = Aspect.AspectFit };
			Pizzas.Add (new Pizza (
				"Пицца с оливками",
				"Колбаса, сыр, соус, оливки",
				"350 р.",
				"450 гр.",
				"olivePizza.jpg"));
			Pizzas.Add (new Pizza (
				"Пицца без оливок",
				"Колбаса, сыр, соус",
				"300 р.",
				"400 гр.",
				"nonOlivePizza.jpg"));
			InitializeComponent ();
			PizzasView.ItemsSource = Pizzas;
		}
		//[ContentProperty ("Source")]
		//public class ImageResExtension : IMarkupExtension
		//{
		//	public string Source { get; set; }
		//
		//	public object ProvideValue (IServiceProvider serviceProvider)
		//	{
		//		if (Source == null)
		//			return null;
		//
		//		// Do your translation lookup here, using whatever method you require
		//		var imageSource = ImageSource.FromResource(Source);
		//
		//		return imageSource;
		//	}
		//}
	}
}

