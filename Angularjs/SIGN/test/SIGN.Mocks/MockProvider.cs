using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.Mocks.Services;
using SIGN.MVC.Controllers.Web;
using System.Collections.Generic;

namespace SIGN.Mocks
{
    public static class MockProvider
    {
        public static IGuidelineService CreateMockGuidelineService(int numberOfGuidelines, string author, bool returnsException)
        {
            List<Guideline> expectedGuidelines = TestDataProvider.CreateTestGuidelines(
                numberOfGuidelines: numberOfGuidelines,
                author: author);
            return new MockGuidelineService(expectedGuidelines, returnsException);
        }

        public static IGuidelineService CreateMockGuidelineService(int numberOfGuidelines)
        {
            return CreateMockGuidelineService(
                numberOfGuidelines: numberOfGuidelines,
                returnsException: false);
        }

        public static IGuidelineService CreateMockGuidelineService(int numberOfGuidelines, bool returnsException)
        {
            List<Guideline> expectedGuidelines = TestDataProvider.CreateTestGuidelines(numberOfGuidelines: numberOfGuidelines);
            return new MockGuidelineService(expectedGuidelines, returnsException);
        }

        public static ILogger<GuidelineController> CreateMockLogger()
        {
            return new MVC.MockLogger();
        }
    }
}
