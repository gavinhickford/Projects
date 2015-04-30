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

        public override string ToString()
        {
            return string.Format("{0}, \n{1}, \n{2}, \n{3}, \n{4}", 
                AddressLine1, 
                AddressLine2, 
                PostTown, 
                County, 
                Postcode);
        }
    }
}
