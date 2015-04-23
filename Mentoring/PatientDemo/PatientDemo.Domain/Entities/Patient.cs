using PatientDemo.Domain.Enums;

namespace PatientDemo.Domain.Entities
{
    public class Patient
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
        public Gender Gender { get; set; }
        public Address HomeAddress { get; set; }
    }
}
