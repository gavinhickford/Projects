using SIGN.Domain.Enums;

namespace SIGN.Angular.ViewModels
{
    public class StepViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public StepType Type { get; set; }
        public int YesStepId { get; set; }
        public int NoStepId { get; set; }
    }
}
