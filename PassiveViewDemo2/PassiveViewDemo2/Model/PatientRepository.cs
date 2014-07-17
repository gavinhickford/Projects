using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveViewDemo2.Model
{
    public class PatientRepository
    {
        private List<Patient> patients = new List<Patient>
        {
            new Patient{Id = 1, Name = "Will Smith"},
            new Patient{Id = 2, Name = "John Jones"},
            new Patient{Id = 3, Name = "Jane Adams"},
            new Patient{Id = 4, Name = "Bill Brown"}
        };

        public Patient GetPatient(int id)
        {
            return patients.Where(p => p.Id.Equals(id)).FirstOrDefault();
        }
    }
}
