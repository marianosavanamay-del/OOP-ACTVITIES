using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIANO__InheritanceWithConstructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//NAme: Savana Mariano
			//Section: IT301
			// Exer Title: Simple Inheritance with Constructor

			// object for the Regualr Student
			RegularStudent regularStudent = new RegularStudent("Conrad Fisher", "Cauliflower", "Bachelor of Science in Medical Technology");

			// object for the Irregular student
			IrregularStudent irregularStudent = new IrregularStudent("Kaiuz Sevilleno", "Bachelor of Science in Industrial Engineering", 20);


			Console.WriteLine("Regular Student");
			regularStudent.StudentBasicInfo();
			regularStudent.SectionEnrolled();



			Console.WriteLine();
			Console.WriteLine("Irregular Student");
			irregularStudent.StudentBasicInfo();
			irregularStudent.EnrolledSemUnits();


			Console.ReadKey();

		}
	}
}
