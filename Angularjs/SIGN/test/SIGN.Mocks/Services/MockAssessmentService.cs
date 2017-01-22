using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace SIGN.Mocks.Services
{
    public class MockAssessmentService : IAssessmentService
    {
        public Task<bool> AddAssessment(int guidelineId, Assessment assessment)
        {
            throw new NotImplementedException();
        }

        public Assessment GetAssessment(int id)
        {
            throw new NotImplementedException();
        }
        
        public Step GetStep(int id)
        {
            throw new NotImplementedException();
        }

        public StepAction GetAction(int stepId, bool condition)
        {
            throw new NotImplementedException();
        }

        public Step GetNextStep(int stepId, bool condition)
        {
            throw new NotImplementedException();
        }
    }
}
