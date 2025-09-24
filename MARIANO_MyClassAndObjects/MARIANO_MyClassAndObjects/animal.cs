using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_MyClassAndObjects
{
    internal class animal
    {
        //This is the fields
        public string mammal;
        public string breed;
        public int age;

        public void info()
        {
            //This is where the method to display the info
            Console.WriteLine();
            Console.WriteLine("mammal: " + mammal);
            Console.WriteLine("breed: " + breed);
            Console.WriteLine("age: " + age);
        }
    }
}
