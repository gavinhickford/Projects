using SIGN.Angular.ViewModels;
using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SIGN.Mocks
{
    public static class TestDataProvider
    {
        public static List<Guideline> CreateTestGuidelines(int numberOfGuidelines)
        {
            var testGuidelines = new List<Guideline>();
            for (int i = 1; i < numberOfGuidelines + 1; i++)
            {
                testGuidelines.Add(CreateTestGuideline(i));
            }

            return testGuidelines;
        }

        public static List<Assessment> CreateTestAssessments(int numberOfAssessments)
        {
            var testAssessments = new List<Assessment>();
            for (int i = 1; i < numberOfAssessments + 1; i++)
            {
                testAssessments.Add(CreateTestAssessment(i));
            }

            return testAssessments;
        }

        public static Assessment CreateTestAssessment(int id)
        {
            return new Assessment
            {
                Id = id,
                Name = $"TestAssessment{id}",
                DateCreated = new DateTime(2010, 1, 1),
                DateModified = new DateTime(2010, 1, 1),
                Type = AssessmentType.Telephone
            };
        }

        public static List<Guideline> CreateTestGuidelines(int numberOfGuidelines, string author)
        {
            var testGuidelines = new List<Guideline>();
            for (int i = 1; i < numberOfGuidelines + 1; i++)
            {
                testGuidelines.Add(CreateTestGuideline(i, author));
            }

            return testGuidelines;
        }

        public static GuidelineViewModel CreateTestGuidelineViewModel(int id)
        {
            return new GuidelineViewModel
            {
                Id = id,
                Name = $"TestGuideline{id}",
                Number = 110,
                Status = GuidelineStatus.CurrentLessThanThreeYears,
                Author = "TestUser",
                DateCreated = new DateTime(2004, 1, 1),
                DateModified = new DateTime(2004, 1, 1),
                DatePublished = new DateTime(2004, 1, 1),
            };
        }

        public static Guideline CreateTestGuideline(int id, string author)
        {
            return new Guideline
            {
                Id = id,
                Name = $"TestGuideline{id}",
                Number = 100,
                Author = author,
                DateCreated = new DateTime(2010, 1, 1),
                DateModified = new DateTime(2010, 1, 1),
                DatePublished = new DateTime(2005, 1, 1),
                Status = GuidelineStatus.GreaterThanSevenYears
            };
        }
        
        public static Guideline CreateTestGuideline(int id)
        {
            return CreateTestGuideline(id, "TestUser");
        }
    }
}
