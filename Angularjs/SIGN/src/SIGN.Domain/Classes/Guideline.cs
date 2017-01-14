using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;
using System.Collections.ObjectModel;

namespace SIGN.Domain.Classes
{
    public class Guideline : BaseEntity
    {
        public Guideline()
        {
            Assessments = new Collection<Assessment>();
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public Collection<Assessment> Assessments { get; set; }
        public string Author { get; set; }
        public GuidelineStatus Status { get; set; }
    }
}
