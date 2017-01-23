using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Services.Tests.Mocks
{
    public class MockRepository : ISIGNRepository
    {
        List<Guideline> _guidelines;
        List<Assessment> _assessments;
        private IEnumerable<Step> _steps;
        private IEnumerable<StepAction> _stepActions;
        private IEnumerable<Decision> _decisions;

        public MockRepository(List<Guideline> expectedGuidelines)
        {
            _guidelines = expectedGuidelines;
        }

        public MockRepository(List<Assessment> expectedAssessments)
        {
            _assessments = expectedAssessments;
        }

        public MockRepository(int numberOfExpectedGuidelines, string authorName)
        {
            _guidelines = new List<Guideline>();

            for (int i = 1; i < numberOfExpectedGuidelines + 1; i++)
            {
                _guidelines.Add(
                    new Guideline
                    {
                        Id = i,
                        Name = $"TestGuideline{i}",
                        Number = 100 + i,
                        Author = authorName,
                        DateCreated = new DateTime(2010, 1, 1),
                        DateModified = new DateTime(2010, 1, 1),
                        DatePublished = new DateTime(2005, 1, 1),
                        Status = GuidelineStatus.GreaterThanSevenYears
                    }
                );
            }
        }


        public MockRepository(int numberOfExpectedGuidelines) : this(numberOfExpectedGuidelines, "TestAuthor")
        {
        }

        public MockRepository(IEnumerable<Step> steps, IEnumerable<StepAction> stepActions, IEnumerable<Decision> decisions)
        {
            _steps = steps;
            _stepActions = stepActions;
            _decisions = decisions;
        }

        public void AddAssessment(int guidelineId, Assessment assessment)
        {
            _assessments.Add(assessment); ;
        }

        public void AddDecision(Decision decision)
        {
            return;
        }

        public void SaveGuideline(Guideline guideline)
        {
            return;
        }

        public void AddStep(Step step)
        {
            return;
        }

        public void AddStepAction(StepAction stepAction)
        {
            return;
        }

        public Assessment GetAssessment(int id)
        {
            return _assessments
                .FirstOrDefault(a => a.Id == id);
        }

        public Guideline GetGuideline(int id)
        {
            return _guidelines
                .FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Guideline> GetGuidelines()
        {
            return _guidelines;
        }

        public IEnumerable<Guideline> GetGuidelinesByAuthor(string AuthorName)
        {
            return _guidelines.Where(g => g.Author == AuthorName);
        }

        public Step GetStep(int id)
        {
            return _steps.FirstOrDefault(s => s.Id == id);
        }

        public int SaveChanges()
        {
            return 1;
        }

        public Task<bool> SaveChangesAsync()
        {
            return Task.FromResult<bool>(true);
        }

        public void AddRecommendationGrade(RecommendationGrade grade)
        {
            throw new NotImplementedException();
        }

        public Decision GetDecision(int stepId, bool choice)
        {
            return _decisions.FirstOrDefault(d => d.Step.Id == stepId && d.Condition == choice);
        }
    }
}
