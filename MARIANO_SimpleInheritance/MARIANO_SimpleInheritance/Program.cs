using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_SimpleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NAme: Savana Mariano
            // Section: IT301
            // Exer Tittle: Simple Inheritance with Properties

            // Instance of Regullar and Irregular Student


            RegularStudent regular = new RegularStudent
            {
                Name = "Savana Mariano",
                Program = "BS in Information and Technology",
                Section = "IT301",
            };
            //Method specific to Regular Student
            Console.WriteLine("Regular Student Info");
            regular.BasicInfo();
            regular.SectionEnrolled();

            Console.WriteLine();
            IrregularStudent irregular = new IrregularStudent
            {
                Name = "Conrad Fisher",
                Program = "BS in Information and Technology",
                UnitsEnrolled = "20",
            };
            //Method Specific to Irregular student
            Console.WriteLine("Irregular Student Info");
            irregular.BasicInfo();
            irregular.EnrolledSemUnits();


            Console.ReadKey();


        }
    }
}
