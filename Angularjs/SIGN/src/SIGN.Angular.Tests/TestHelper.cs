using AutoMapper;
using SIGN.Angular.ViewModels;
using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
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

        public static void InitialiseMappings()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<GuidelineViewModel, Guideline>().ReverseMap();
            });
        }
    }
}
