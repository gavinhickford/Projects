using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using SIGN.Mocks;
using SIGN.Services.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SIGN.Services.Tests
{
    public class AssessmentServiceTests
    {
        [Fact]
        public void GetAssessment_ReturnsAssessmentById()
        {
            //Arrange
            const int id = 1;
            Assessment expectedAssessment = TestDataProvider.CreateTestAssessment(id);

            ISIGNRepository mockRepository = new MockRepository(
                expectedAssessments: new List<Assessment> { expectedAssessment });

            IAssessmentService service = new AssessmentService(mockRepository);

            // Act
            Assessment actual = service.GetAssessment(id);

            // Assert
            Assert.Equal(expectedAssessment.Id, actual.Id);
        }

        [Fact]
        public void GetAssessment_NoAssessment_ReturnsNull()
        {
            //Arrange
            ISIGNRepository mockRepository = new MockRepository(
                expectedAssessments: new List<Assessment>());

            IAssessmentService service = new AssessmentService(mockRepository);

            // Act
            Assessment actual = service.GetAssessment(1);

            // Assert
            Assert.Null(actual);
        }
    }
}
