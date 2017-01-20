using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.Mocks.Services;
using System.Collections.Generic;

namespace SIGN.Mocks
{
    public static class MockProvider
    {
        public static ISIGNService CreateMockSignService(int numberOfGuidelines, string author, bool returnsException)
        {
            List<Guideline> expectedGuidelines = TestDataProvider.CreateTestGuidelines(
                numberOfGuidelines: numberOfGuidelines,
                author: author);
            return new MockSignService(expectedGuidelines, returnsException);
        }

        public static ISIGNService CreateMockSignService(int numberOfGuidelines)
        {
            return CreateMockSignService(
                numberOfGuidelines: numberOfGuidelines,
                returnsException: false);
        }

        public static ISIGNService CreateMockSignService(int numberOfGuidelines, bool returnsException)
        {
            List<Guideline> expectedGuidelines = TestDataProvider.CreateTestGuidelines(numberOfGuidelines: numberOfGuidelines);
            return new MockSignService(expectedGuidelines, returnsException);
        }
    }
}
