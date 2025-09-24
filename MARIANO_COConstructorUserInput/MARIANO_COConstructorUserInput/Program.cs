using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_COConstructorUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Savana Mariano
            //Section: IT301
            //Exercise Title: Create a Class

            //This is the user input
            Console.WriteLine("Hello! Are you fond of puppies and kittens?");
            Console.WriteLine("These are our adorable pets!");
            Console.WriteLine("They are so playful and friendly, I can suggest which pet are you choosing");
            Console.WriteLine();

            Console.Write("Enter mammal: ");
            string aMammal = Console.ReadLine();

            Console.Write("Enter breed: ");
            string aBreed = Console.ReadLine();

            Console.Write("Enter age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Feel free to chose what pet you adore");

            //Initialize a method
            Animal animal = new Animal(aMammal, aBreed, Age);

            //Call the object to display the object details
            animal.DisplayAnimalInfo();

            Console.ReadKey();
        }
    }
}
