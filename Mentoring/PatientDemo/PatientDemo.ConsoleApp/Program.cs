using PatientDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDemo.Domain.Enums;

namespace PatientDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address 
            {
                AddressLine1 = "1 West Street",
                AddressLine2 = "Tuffley",
                PostTown = "Gloucester",
                County = "Gloucestershire",
                Postcode = "GL4 ONA"
            };

            var myPatient = new Patient 
            {
                Surname = "Smith",
                Forename = "John",
	            Gender = Gender.Male,
	            Height = 1.75f,
			    Weight = 75.00f,
                HomeAddress = address
            };

            Console.WriteLine(myPatient.ToString());
            Console.WriteLine(myPatient.HomeAddress.ToString());
            Console.ReadKey();
        }
    }
}
