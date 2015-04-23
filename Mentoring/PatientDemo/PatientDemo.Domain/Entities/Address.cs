using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.Domain.Entities
{
    public struct Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostTown { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
    }
}
