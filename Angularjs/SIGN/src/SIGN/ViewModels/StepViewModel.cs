using SIGN.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.ViewModels
{
    public class StepViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public StepType Type { get; set; }

        public int YesStepId { get; set; }
        public int NoStepId { get; set; }
        //public bool IsStartStep { get; set; }
    }
}
