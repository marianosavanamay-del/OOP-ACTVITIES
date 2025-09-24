using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_CaO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Savana Mariano
            // Section: IT301
            // Exercise title: Creating a Class

            // Instantiate a person
            Class1 person = new Class1();

            // Initialized values for the fields
            person.age = 19;
            person.name = "Savana Mariano";
            person.gender = "Female";

            // method to display greetings
            person.greet();
            Console.ReadKey();
        }
    }
}
