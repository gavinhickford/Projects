using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDemo.Domain.Entities;
using PatientDemo.Domain.Enums;

namespace PatientDemo.Domain.Service
{
	public class PatientService
	{
		public List<Patient> GetPatients()
		{
			var address1 = new Address
			{
				AddressLine1 = "1 West Street",
				AddressLine2 = "Tuffley",
				PostTown = "Gloucester",
				County = "Gloucestershire",
				Postcode = "GL4 ONA"
			};

			var myPatient1 = new Patient
			{
				Surname = "Smith",
				Forename = "John",
				Gender = Gender.Male,
				Height = 1.75f,
				Weight = 75.00f,
				HomeAddress = address1,
				DateOfBirth = new DateTime(1977, 12, 12)
			};

			var address2 = new Address
			{
				AddressLine1 = "3 Smith Street",
				AddressLine2 = "Tuffley",
				PostTown = "Gloucester",
				County = "Gloucestershire",
				Postcode = "GL4 YG5"
			};

			var myPatient2 = new Patient
			{
				Surname = "Brown",
				Forename = "June",
				Gender = Gender.Female,
				Height = 1.56f,
				Weight = 78.00f,
				HomeAddress = address2,
				DateOfBirth = new DateTime(1955, 11, 11)
			};

			var address3 = new Address
			{
				AddressLine1 = "4 Main Street",
				AddressLine2 = "Tuffley",
				PostTown = "Gloucester",
				County = "Gloucestershire",
				Postcode = "GL4 TR1"
			};

			var myPatient3 = new Patient
			{
				Surname = "Anderson",
				Forename = "James",
				Gender = Gender.Male,
				Height = 1.73f,
				Weight = 65.00f,
				HomeAddress = address3,
				DateOfBirth = new DateTime(1932, 3, 3)
			};

			var address4 = new Address
			{
				AddressLine1 = "5 East Avenue",
				AddressLine2 = "Tuffley",
				PostTown = "Gloucester",
				County = "Gloucestershire",
				Postcode = "GL4 ES1"
			};

			var myPatient4 = new Patient
			{
				Surname = "Green",
				Forename = "Wendy",
				Gender = Gender.Female,
				Height = 1.55f,
				Weight = 79.00f,
				HomeAddress = address4,
				DateOfBirth = new DateTime(1988, 3, 6)
			};

			return new List<Patient> {myPatient1, myPatient2, myPatient3, myPatient4};
		}
	}
}
