using AutoMapper;
using SIGN.Angular.ViewModels;
using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using SIGN.Mocks.Services;
using System;
using System.Collections.Generic;

namespace SIGN.Angular.Tests
{
    public static class TestHelper
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

        internal static ISIGNService CreateMockSignService(int numberOfGuidelines)
        {
            return CreateMockSignService(
                numberOfGuidelines: numberOfGuidelines, 
                returnsException: false);
        }

        internal static ISIGNService CreateMockSignService(int numberOfGuidelines, bool returnsException)
        {
            List<Guideline> expectedGuidelines = CreateTestGuidelines(numberOfGuidelines: 1);
            return new MockSignService(expectedGuidelines, returnsException);
        }

        internal static GuidelineViewModel CreateTestGuidelineViewModel(int id)
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

        internal static Guideline CreateTestGuideline(int id)
        {
            return new Guideline
            {
                Id = id,
                Name = $"TestGuideline{id}",
                Number = 100,
                Author = "TestUser",
                DateCreated = new DateTime(2010, 1, 1),
                DateModified = new DateTime(2010, 1, 1),
                DatePublished = new DateTime(2005, 1, 1),
                Status = GuidelineStatus.GreaterThanSevenYears
            };
        }

        public static void InitialiseMappings()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<GuidelineViewModel, Guideline>().ReverseMap();
            });
        }
    }
}
