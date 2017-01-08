using SIGN.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.ViewModels
{
    public class AssessmentViewModel
    {
        public string Name { get; set; }

        public AssessmentType Type { get; set; }

        public string Description { get; set; }
    }
}
