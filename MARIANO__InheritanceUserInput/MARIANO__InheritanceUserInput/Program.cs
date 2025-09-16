using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO__InheritanceUserInput
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Name: Savana Mariano
			//Section: It301
			// Exer Title: Inheritance with User Input

			// this is where the user will choose which item he/she likes
			Console.WriteLine("Please choose a Number:  ");
			Console.WriteLine("1 - Baggy Jeans, 2 - Flared Jeans");
			int choice = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Details of your chosen Jeans:   ");
			Console.WriteLine("");

			if (choice == 1)
			{
				//User Input for Baggy Jeans
				BaggyJeans baggyJeans1 = new BaggyJeans();
				Console.Write("Please Enter the Brand:  ");
				string brand = Console.ReadLine();

				Console.Write("Enter the Name:   ");
				string name = Console.ReadLine();

				Console.Write("Enter the Color:   ");
				string color = Console.ReadLine();

				// Set the properties for the Baggy Jeans Object
				baggyJeans1.Brand = brand;
				baggyJeans1.Name = name;
				baggyJeans1.Color = color;

				//display the BaggyJeans info
				Console.WriteLine();
				Console.Write("Here's the Details of your Order:   ");
				Console.WriteLine();
				baggyJeans1.BaggyJeansInfo();

			}

			// If the user chooses Flared Jeans, get its details from user input
			else if (choice == 2)
			{
				//User input for Flared Jeans
				FlaredJeans flaredJeans1 = new FlaredJeans();
				Console.Write("Please Enter the Brand:  ");
				string brand = Console.ReadLine();

				Console.Write("Enter the Size:  ");
				string size = Console.ReadLine();

				Console.Write("Enter the Price:  ");
				string price = Console.ReadLine();

				// Set the properties for the Flared Jeans objects
				flaredJeans1.Brand = brand;
				flaredJeans1.Size = size;
				flaredJeans1.Price = price;

				//Display the flared jeans info
				Console.WriteLine();
				Console.WriteLine("Here's the Details of your Order:  ");
				Console.WriteLine();
				flaredJeans1.FlaredJeansInfo();
			}
			else
			{
				Console.WriteLine("Input Again");

			}

			Console.ReadKey();
		}

	}
}

