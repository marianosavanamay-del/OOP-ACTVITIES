using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_MyClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Savana Mariano
            //Section: IT301
            //Title: MyClassAndObjects

            //This is the object of my classs
            animal animal1 = new animal();
            animal animal2 = new animal();

            //This is the values for the fields
            animal1.mammal = "Dog";
            animal1.breed = "Golden Retriever";
            animal1.age = 1;

            animal2.mammal = "Cat";
            animal2.breed = "Persian Cat";
            animal2.age = 3;

            //this is to call the method\
            animal1.info();
            animal2.info();

            Console.ReadKey();

        }
    }
}
