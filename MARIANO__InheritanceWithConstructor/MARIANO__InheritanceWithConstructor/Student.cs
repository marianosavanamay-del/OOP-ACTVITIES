using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO__InheritanceWithConstructor
{

	class Student // This is the base class
	{
		public string Name { get; set; }

		public string Program { get; set; }



		// This is the constructor
		public Student(string name, string program)
		{
			Name = name;
			Program = program;

		}

		// This is the method to display Student Info
		public void StudentBasicInfo()
		{
			Console.WriteLine($"Name:      {Name}");
			Console.WriteLine($"Program:  {Program}");
		}
	}

	class RegularStudent : Student  // This is the derived class
	{

		public string Section { get; set; }

		// This is the constructor of the Derived class
		public RegularStudent(string name, string program, string section) : base(name, program)
		{

			Section = section;
		}
		//Method to display Regular student info
		public void SectionEnrolled()
		{

			Console.WriteLine($"Section:  {Section}");
		}

	}
	class IrregularStudent : Student  // Also a derived class
	{

		public int UnitsEnrolled { get; set; }

		//Constructor of the derived class
		public IrregularStudent(string name, string program, int units) : base(name, program)
		{

			UnitsEnrolled = units;
		}
		// Method to display Irregular student info
		public void EnrolledSemUnits()
		{

			Console.WriteLine($"UnitsEnrolled:  {UnitsEnrolled}");



			Console.ReadLine();
		}

	}

}
