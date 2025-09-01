using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is the instance of Jeans class
            Jeans jeans1 = new Jeans();

            // This is the properties using the setter method\
            jeans1.Brand = "Uniqlo";
            jeans1.Size = "Small";


            // Display Jeans information using method
            jeans1.DisplayInfo();


            Console.ReadKey();

        }
    }
}
