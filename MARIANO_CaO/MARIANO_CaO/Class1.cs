using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_CaO
{
    internal class Class1
    {
        //fields
        public string name, gender;
        public int age;

        public void greet()
        {
            Console.WriteLine("Hello " + name + " Rise n Shine!");
            Console.WriteLine("Your " + age + " yrs old " + "and " + gender);
        }
    }
}
