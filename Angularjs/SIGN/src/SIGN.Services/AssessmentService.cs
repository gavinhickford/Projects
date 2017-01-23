using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System.Threading.Tasks;

namespace SIGN.Services
{
    public class AssessmentService : IAssessmentService
    {
        private ISIGNRepository _repository;

        public AssessmentService(ISIGNRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAssessment(int guidelineId, Assessment assessment)
        {
            _repository.AddAssessment(guidelineId, assessment);
            return await _repository.SaveChangesAsync();
        }

        public StepAction GetAction(int stepId, bool condition)
        {
            Decision decision = _repository.GetDecision(stepId, condition);

            if (decision != null)
            {
                return decision.Action;
            }

            return null;
        }

        public Step GetStep(int id)
        {
            return _repository.GetStep(id);
        }

        public Step GetNextStep(int stepId, bool condition)
        {
            StepAction action = GetAction(stepId, condition);

            if (action != null)
            {
                return action.NextStep;
            }

            return null;
        }

        public Assessment GetAssessment(int id)
        {
            return _repository.GetAssessment(id);
        }
    }
}
