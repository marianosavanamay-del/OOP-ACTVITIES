using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO_SimpleInheritance
{
    internal class Student
    {
        // This is the method of the base class
        public string Name { get; set; }
        public string Program { get; set; }

        public void BasicInfo()
        {
            Console.WriteLine($"Name:     {Name}");
            Console.WriteLine($"Program:  {Program}");

        }
    }
    class RegularStudent : Student  // Derived Class
    {
        // Method specific to Student class
        public string Section { get; set; }

        public void SectionEnrolled()
        {
            Console.WriteLine($"Section:   {Section}");
        }

    }
    class IrregularStudent : Student     // Derived Class
    {
        // Method specific to Irregular class
        public string UnitsEnrolled { get; set; }

        public void EnrolledSemUnits()
        {
            Console.WriteLine($"Units this Semester:   {UnitsEnrolled}");
        }
    }


}

