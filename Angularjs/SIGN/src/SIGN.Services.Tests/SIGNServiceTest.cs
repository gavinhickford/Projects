using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SIGN.Services.Tests
{
    
    public class SIGNServiceTest
    {
        [Fact]
        public void GetGuidlines_WhenRepositoryHasSingleGuideline_ReturnsSingleGuideline()
        {
            // Arrange
            const int numberOfExpectedGuidelines = 1;

            ISIGNRepository mockSignRepository = new Mocks.MockRepository(
                numberOfExpectedGuidelines: numberOfExpectedGuidelines);
            ISIGNService signService = new SIGNService(mockSignRepository);

            // Act
            IEnumerable<Guideline> actual = signService.GetGuidelines();

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
            ISIGNService signService = new SIGNService(mockSignRepository);

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
            ISIGNService signService = new SIGNService(mockSignRepository);

            // Act
            IEnumerable<Guideline> actual = signService.GetGuidelines();

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
            ISIGNService signService = new SIGNService(mockSignRepository);

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
            ISIGNService signService = new SIGNService(mockSignRepository);

            // Act
            Guideline actual = signService.GetGuideline(expectedIdentifier);

            // Assert
            Assert.Null(actual);
        }

    }
}
