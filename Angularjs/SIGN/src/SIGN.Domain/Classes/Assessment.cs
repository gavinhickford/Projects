using SIGN.Domain.Enums;

namespace SIGN.Domain.Classes
{
    public class Assessment : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public AssessmentType Type { get; set; }
        public Guideline Guideline { get; set; }
        public int GuidelineId { get; set; }
        public Step FirstStep { get; set; }
        public int FirstStepId { get; set; }
    }
}
