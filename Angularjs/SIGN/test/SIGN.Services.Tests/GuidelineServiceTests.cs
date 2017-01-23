using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.Mocks;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SIGN.Services.Tests
{
    public class GuidelineServiceTests
    {
        [Fact]
        public void GetGuidlines_WhenRepositoryHasSingleGuideline_ReturnsSingleGuideline()
        {
            // Arrange
            const int numberOfExpectedGuidelines = 1;

            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: numberOfExpectedGuidelines);
            IGuidelineService guidelineService = new GuidelineService(mockSignRepository);

            // Act
            IEnumerable<Guideline> actual = guidelineService.GetGuidelines();

            // Assert
            Assert.Equal(numberOfExpectedGuidelines, actual.Count()); 
        }

        [Fact]
        public void GetGuidlines_WhenRepositoryHasNoGuidelines_ReturnsEmptyList()
        {
            // Arrange
            const int numberOfExpectedGuidelines = 0;

            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: numberOfExpectedGuidelines);
            IGuidelineService signService = new GuidelineService(mockSignRepository);

            // Act
            IEnumerable<Guideline> actual = signService.GetGuidelines();

            // Assert
            Assert.Equal(numberOfExpectedGuidelines, actual.Count());
        }

        [Fact]
        public void GetGuidlines_WhenRepositoryHasTenGuidelines_ReturnsTenGuidelines()
        {
            // Arrange
            const int numberOfExpectedGuidelines = 10;

            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: numberOfExpectedGuidelines);
            IGuidelineService guidelineService = new GuidelineService(mockSignRepository);

            // Act
            IEnumerable<Guideline> actual = guidelineService.GetGuidelines();

            // Assert
            Assert.Equal(numberOfExpectedGuidelines, actual.Count());
        }

        [Fact]
        public void GetMyGuidlines_WhenRepositoryHasFiveGuidelines_ReturnsFiveGuidelines()
        {
            // Arrange
            const int numberOfExpectedGuidelines = 5;
            const string author = "TestAuthor"; 

            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: numberOfExpectedGuidelines,
                authorName: author );

            IGuidelineService guidelineService = new GuidelineService(mockSignRepository);

            // Act
            IEnumerable<Guideline> actual = guidelineService.GetMyGuidelines(author);

            // Assert
            Assert.Equal(numberOfExpectedGuidelines, actual.Count());
        }

        [Fact]
        public void GetGuidline_WhenRepositoryIncludesId_ReturnsCorrectGuideline()
        {
            // Arrange
            const int numberOfExpectedGuidelines = 10;
            const int expectedIdentifier = 1;

            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: numberOfExpectedGuidelines);
            IGuidelineService signService = new GuidelineService(mockSignRepository);

            // Act
            Guideline actual = signService.GetGuideline(expectedIdentifier);

            // Assert
            Assert.Equal(expectedIdentifier, actual.Id);
        }

        [Fact]
        public void GetGuidline_WhenRepositoryDoesNotIncludeId_ReturnsNull()
        {
            // Arrange
            const int numberOfExpectedGuidelines = 10;
            const int expectedIdentifier = 11;

            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: numberOfExpectedGuidelines);
            IGuidelineService signService = new GuidelineService(mockSignRepository);

            // Act
            Guideline actual = signService.GetGuideline(expectedIdentifier);

            // Assert
            Assert.Null(actual);
        }

        [Fact]
        public async void SaveGuideline_Success_ReturnsTrue()
        {
            // Arrange
            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: 0);

            IGuidelineService signService = new GuidelineService(mockSignRepository);
            Guideline newGuideline = TestDataProvider.CreateTestGuideline(1);

            // Act
            bool result = await signService.SaveGuideline(newGuideline);

            // Assert
            Assert.True(result);
        }
    }
}
