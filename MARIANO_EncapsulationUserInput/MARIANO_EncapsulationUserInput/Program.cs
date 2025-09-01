using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Savana Mariano
            // Section: IT301
            // EXer Title: Basics on Encapsulation


            // This is the instanx=ce of the Jeans class
            Jeans jeans1 = new Jeans();

            // This is the properties using setter method
            Console.WriteLine("Input the Brand of the Jeans:       ");
            jeans1.Brand = Console.ReadLine();

            Console.WriteLine("Input the Size of the Jeans:        ");
            jeans1.Size = Console.ReadLine();


            // Display Jeans information using method
            jeans1.DisplayInfo();


            Console.ReadKey();

        }
    }
}
