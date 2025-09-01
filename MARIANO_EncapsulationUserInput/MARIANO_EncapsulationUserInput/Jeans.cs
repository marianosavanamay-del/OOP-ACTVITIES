using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_EncapsulationUserInput
{
    internal class Jeans
    {
        // Declaring the class fields
        private string brand;
        private string size;

        // This is the setter for the brand
        public string Brand
        {
            get { return brand; }
            set { brand = value; }

        }
        // This is the setter for the size
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        // THis is the method of the Jeans fit
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand:           {Brand},    Size:     {Size}");

        }

    }
}