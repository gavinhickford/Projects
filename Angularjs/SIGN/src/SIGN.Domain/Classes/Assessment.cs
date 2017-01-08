using SIGN.Domain.Interfaces;
using System;

namespace SIGN.Domain.Classes
{
    public class Assessment : IModificationHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AssessmentType Type { get; set; }
        public Guideline Guideline { get; set; }
        public int GuidelineId { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}
