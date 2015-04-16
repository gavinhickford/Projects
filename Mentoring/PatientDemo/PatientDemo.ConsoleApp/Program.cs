using PatientDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPatient = new Patient();
            myPatient.Surname = "Smith";
            myPatient.Forename = "John";
	        myPatient.Gender = "Male";
	        myPatient.Height = 1.75f;
			myPatient.Weight = 75.00f;
            Console.WriteLine(myPatient.ToString());
            Console.ReadKey();
        }
    }
}
