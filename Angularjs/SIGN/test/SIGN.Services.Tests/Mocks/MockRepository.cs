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
        List<Guideline> _expectedGuidelines;

        public MockRepository(List<Guideline> expectedGuidelines)
        {
            _expectedGuidelines = expectedGuidelines;
        }

        public MockRepository(int numberOfExpectedGuidelines)
        {
            _expectedGuidelines = new List<Guideline>();

            for (int i = 1; i < numberOfExpectedGuidelines + 1; i++)
            {
                _expectedGuidelines.Add(
                    new Guideline
                    {
                        Id = i,
                        Name = $"TestGuideline{i}",
                        Number = 100 + i,
                        Author = "TestUser",
                        DateCreated = new DateTime(2010, 1, 1),
                        DateModified = new DateTime(2010, 1, 1),
                        DatePublished = new DateTime(2005, 1, 1),
                        Status = GuidelineStatus.GreaterThanSevenYears
                    }
                );
            }
        }

        public void AddAssessment(int guidelineId, Assessment assessment)
        {
            return;
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

        public StepAction GetAction(int stepId, bool choice)
        {
            return new StepAction
            {
                Id = 1,
                DateCreated = new DateTime(2017, 1, 1),
                DateModified = new DateTime(2017, 1, 1)
            };
        }

        public Assessment GetAssessment(int id)
        {
            return new Assessment
            {
                Id = 1,
                Name = "Test Assessment",
                DateCreated = new DateTime(2017, 1, 1),
                DateModified = new DateTime(2017, 1, 1),
                Description = "Test Description",
                Type = AssessmentType.Telephone
            };
        }

        public Guideline GetGuideline(int id)
        {
            return _expectedGuidelines
                .FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Guideline> GetGuidelines()
        {
            return _expectedGuidelines;
        }

        public IEnumerable<Guideline> GetGuidelinesByAuthor(string AuthorName)
        {
            return new List<Guideline>
            {
                new Guideline {
                    Id = 1,
                    Author = AuthorName,
                    DateCreated = new DateTime(2017, 1, 1),
                    DateModified = new DateTime(2017, 1, 1),
                    DatePublished = new DateTime(2017, 1, 1)
                }
            };
        }

        public Step GetStep(int id)
        {
            return new Step
            {
                Id = id,
                Text ="Test Text",
                DateCreated = new DateTime(2017, 1, 1),
                DateModified = new DateTime(2017, 1, 1),
                Type = StepType.Question
            };
        }

        public int SaveChanges()
        {
            return 1;
        }

        public Task<bool> SaveChangesAsync()
        {
            return new Task<bool>(() => true);
        }

        public void AddRecommendationGrade(RecommendationGrade grade)
        {
            throw new NotImplementedException();
        }
    }
}
