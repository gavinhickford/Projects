using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Angular.Controllers.Api;
using SIGN.Angular.Tests.Mocks;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace SIGN.Angular.Tests.Controllers
{
    public class AppControllerTests
    {
        private readonly ILogger<GuidelineController> _mockLogger = new MockLogger();

        [Fact]
        public void GuidelineController_Get_ReturnsOKResponse()
        {
            // Arrange
            TestHelper.InitialiseMappings();

            List<Guideline> expectedGuidelines =
                TestHelper.CreateTestGuidelines
                (
                    numberOfGuidelines: 1
                );

            ISIGNService mockSIGNService = new MockSignService(expectedGuidelines);

            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get();

            // Assert
            Assert.True(response is OkObjectResult);
        }
        
        [Fact]
        public void GuidelineController_GetById_ReturnsOKResponse()
        {
            // Arrange
            TestHelper.InitialiseMappings();

            List<Guideline> expectedGuidelines =
                TestHelper.CreateTestGuidelines
                (
                    numberOfGuidelines: 1
                );

            ISIGNService mockSIGNService = new MockSignService(expectedGuidelines);
            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get(1);

            // Assert
            Assert.True(response is OkObjectResult);
        }

        [Fact]
        public void GuidelineController_GetById_NotFound_Returns404()
        {
            // Arrange
            TestHelper.InitialiseMappings();

            List<Guideline> expectedGuidelines =
               TestHelper.CreateTestGuidelines
               (
                   numberOfGuidelines: 1
               );

            ISIGNService mockSIGNService = new MockSignService(expectedGuidelines);
            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get(2);

            // Assert
            Assert.True(response is NotFoundResult);
        }

        [Fact]
        public void GuidelineController_Get_ExceptionThrown_Returns500()
        {
            TestHelper.InitialiseMappings();

            List<Guideline> expectedGuidelines =
               TestHelper.CreateTestGuidelines
               (
                   numberOfGuidelines: 1
               );

            ISIGNService mockSIGNService = new MockSignService(
                expectedGuidelines: expectedGuidelines,
                returnsException: true);

            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get();

            Assert.True(response is BadRequestObjectResult);
        }
    }
}
