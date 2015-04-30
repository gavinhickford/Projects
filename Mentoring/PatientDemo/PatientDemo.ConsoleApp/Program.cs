using PatientDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDemo.Domain.Enums;
using PatientDemo.Domain.Service;

namespace PatientDemo.ConsoleApp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<Patient> patients = new PatientService().GetPatients();

			int count = patients.Count();
			for (int i = 0; i < count; ++i)
			{
				Console.WriteLine("Patient {0}:", i);
				Console.WriteLine(patients[i]);
				Console.WriteLine();
			}

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
					HomeAddress = address,
					DateOfBirth = new DateTime(1977, 12, 12)
				};

			//Console.WriteLine(myPatient.ToString());

			//int x = 10;
			//do
			//{
			//	Console.WriteLine(x);
			//	x++;
			//} while (x < 10);

			//for (int i = 10; i < 100; i = i + 10)
			//{
			//	Console.WriteLine(i);
			//}

			Console.ReadKey();
		}
	}
}