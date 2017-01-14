using AutoMapper;
using SIGN.Angular.ViewModels;
using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using System;
using System.Collections.Generic;
using SIGN.Domain.Interfaces;
using SIGN.Angular.Tests.Mocks;

namespace SIGN.Angular.Tests
{
    public static class TestHelper
    {
        public static List<Guideline> CreateTestGuidelines(int numberOfGuidelines)
        {
            var testGuidelines = new List<Guideline>();
            for (int i = 1; i < numberOfGuidelines + 1; i++)
            {
                testGuidelines.Add(
                    new Guideline
                    {
                        Id = i,
                        Name = $"TestGuideline{i}",
                        Number = 100,
                        Author = "TestUser",
                        DateCreated = new DateTime(2010, 1, 1),
                        DateModified = new DateTime(2010, 1, 1),
                        DatePublished = new DateTime(2005, 1, 1),
                        Status = GuidelineStatus.GreaterThanSevenYears
                    });
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

        public static void InitialiseMappings()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<GuidelineViewModel, Guideline>().ReverseMap();
            });
        }
    }
}
