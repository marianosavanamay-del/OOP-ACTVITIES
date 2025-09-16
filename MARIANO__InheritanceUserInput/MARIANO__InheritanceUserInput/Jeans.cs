using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO__InheritanceUserInput
{
	internal class Jeans
	{
		public string Brand { get; set; }

		// display the brand of the jeans
		public void BrandInfo()
		{
			Console.Clear();
			Console.Write("Brand:    ");
			Console.WriteLine("Brand");
		}
	}
	class BaggyJeans : Jeans  // First derived class
	{
		public string Name { get; set; }
		public string Color { get; set; }

		//Display the Baggy jeans details including together with brand, name, and color
		public void BaggyJeansInfo()
		{

			Console.Clear();
			Console.WriteLine("Baggy Jeans Details:    ");
			Console.WriteLine();
			Console.Write("Brand:  ");
			Console.WriteLine(Brand);
			Console.Write("Name:   ");
			Console.WriteLine(Name);
			Console.Write("Color:  ");
			Console.WriteLine(Color);

		}
	}
	class FlaredJeans : Jeans
	{
		public string Size { get; set; }
		public string Price { get; set; }

		//dzisplay Faled jeans Details together with brand, size and prize
		public void FlaredJeansInfo()
		{
			Console.Clear();
			Console.WriteLine("Flared Jeans Details:   ");
			Console.WriteLine();
			Console.Write("Brand:  ");
			Console.WriteLine(Brand);
			Console.Write("Size:  ");
			Console.WriteLine(Size);
			Console.Write("Price:  ");
			Console.WriteLine(Price);
		}


	}

}

	

