using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIGN.Domain.Classes;

namespace SIGN.Angular.Tests.Mocks
{
    public class MockSignService : ISIGNService
    {
        private List<Guideline> _expectedGuidelines;
        private bool _returnsException;

        public MockSignService(List<Guideline> expectedGuidelines)
            : this(expectedGuidelines, false)
        {
        }

        public MockSignService(List<Guideline> expectedGuidelines, bool returnsException)
        {
            _expectedGuidelines = expectedGuidelines;
            _returnsException = returnsException;
        }

        public Task<bool> AddAssessment(int guidelineId, Assessment assessment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveGuideline(Guideline guideline)
        {
            return Task.FromResult<bool>(true);
        }

        public Assessment GetAssessment(int id)
        {
            throw new NotImplementedException();
        }

        public Guideline GetGuideline(int id)
        {
            return _expectedGuidelines
                .FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Guideline> GetGuidelines()
        {
            if (_returnsException)
            {
                throw new Exception();
            }

            return _expectedGuidelines;
        }

        public IEnumerable<Guideline> GetMyGuidelines(string username)
        {
            return _expectedGuidelines
                .Where(g => g.Author == username);
        }

        public Step GetStep(int id)
        {
            throw new NotImplementedException();
        }

        public StepAction GetAction(int stepId, bool condition)
        {
            throw new NotImplementedException();
        }
    }
}
