using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.Domain.Utilities
{
	internal class AgeCalculator
	{
		internal static string Calculate(DateTime dateOfBirth, DateTime currentDate)
		{
			int year = 0;
			int month = 0;

			if (currentDate.Month < dateOfBirth.Month)
			{
				int y1 = currentDate.Year - 1;
				year = y1 - dateOfBirth.Year;
				int m1 = 12 - dateOfBirth.Month;
				month = m1 + currentDate.Month;
			}
			else if (dateOfBirth.Month < currentDate.Month)
			{
				year = currentDate.Year - dateOfBirth.Year;
				month = currentDate.Month - dateOfBirth.Month;
			}
			else if (currentDate.Month == dateOfBirth.Month)
			{
				year = currentDate.Year - dateOfBirth.Year;
			}

			return string.Format("Age : {0} years {1} months", year, month);
		}
	}
}
