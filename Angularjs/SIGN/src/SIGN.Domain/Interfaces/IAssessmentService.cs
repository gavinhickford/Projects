using SIGN.Domain.Classes;
using System.Threading.Tasks;

namespace SIGN.Domain.Interfaces
{
    public interface IAssessmentService
    {
        Assessment GetAssessment(int id);
        Step GetStep(int id);
        Task<bool> AddAssessment(int guidelineId, Assessment assessment);
        StepAction GetAction(int stepId, bool condition);
        Step GetNextStep(int stepId, bool condition);
    }
}
