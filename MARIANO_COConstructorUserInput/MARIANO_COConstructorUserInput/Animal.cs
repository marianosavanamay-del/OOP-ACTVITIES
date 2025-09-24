using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_COConstructorUserInput
{
    internal class Animal
    {
        public string mammal;
        public string breed;
        public int age;

        public Animal(string aMammal, string aBreed, int aAge) //Parameterized Constructor
        {
            mammal = aMammal;
            breed = aBreed;
            age = aAge;
        }

        public void DisplayAnimalInfo()
        {
            Console.Clear();
            Console.WriteLine("These are the Animal details");
            Console.WriteLine();
            Console.WriteLine("Mammal:" + mammal);
            Console.WriteLine("Breed:" + breed);
            Console.WriteLine("Age:" + age);
        }
    }
}
