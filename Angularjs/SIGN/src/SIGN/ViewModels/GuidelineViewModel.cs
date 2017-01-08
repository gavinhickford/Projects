using SIGN.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGN.ViewModels
{
    public class GuidelineViewModel
    {
        public GuidelineViewModel(Guideline guideline)
        {
            Number = guideline.Number;
            Name = guideline.Name;
            DatePublished = guideline.DatePublished;
            Assessments = guideline.Assessments;
        }

        public int Number { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime DatePublished { get; set; }

        public IEnumerable<Assessment> Assessments { get; set; }
    }
}
