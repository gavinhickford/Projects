using PatientDemo.Domain.Enums;
using PatientDemo.Domain.Utilities;
using System;

namespace PatientDemo.Domain.Entities
{
    public class Patient
    {
        public string Surname { get; set; }
        
        public string Forename { get; set; }
        
        public Gender Gender { get; set; }
        
        public Address HomeAddress { get; set; }
		
        public DateTime DateOfBirth { get; set; }
		
        public float Height { get; set; }
	    
        public float Weight { get; set; }
        
        public float BMI 
        {
            get 
            {
                return BMICalculator.Calculate(Height, Weight);
            }
        }

	    public string Age
	    {
		    get
		    {
			    return AgeCalculator.Calculate(DateOfBirth, DateTime.Now);
			}
	    }

	    public override string ToString()
		{
			return string.Format("{0} {1}\nAge: {2}\nGender :{3}\nBMI: {4}\nAddress: {5}", 
				Forename, 
				Surname, 
				Age,
				Gender, 
				BMI,
				HomeAddress);
		}
    }
}
