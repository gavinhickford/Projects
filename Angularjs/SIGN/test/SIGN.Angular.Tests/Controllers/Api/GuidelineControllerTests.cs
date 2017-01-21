using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Angular.Controllers.Api;
using SIGN.Angular.ViewModels;
using SIGN.Domain.Interfaces;
using SIGN.Mocks;
using SIGN.Mocks.Angular;
using Xunit;

namespace SIGN.Angular.Tests.Controllers.Api
{
    public class GuidelineControllerTests
    {
        private readonly ILogger<GuidelineController> _mockLogger = new MockLogger();

        [Fact]
        public void Get_Guidelines_ReturnsOKResponse()
        {
            // Arrange
            TestMappings.Initialise();
            ISIGNService mockSIGNService = MockProvider.CreateMockSignService(numberOfGuidelines: 1);
            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get();

            // Assert
            Assert.True(response is OkObjectResult);
        }
        
        [Fact]
        public void Get_GuidelineById_ReturnsOKResponse()
        {
            // Arrange
            TestMappings.Initialise();
            ISIGNService mockSIGNService = MockProvider.CreateMockSignService(numberOfGuidelines: 1);
            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get(1);

            // Assert
            Assert.True(response is OkObjectResult);
        }

        [Fact]
        public void Get_GuidelineById_NotFound_Returns404()
        {
            // Arrange
            TestMappings.Initialise();
            ISIGNService mockSIGNService = MockProvider.CreateMockSignService(numberOfGuidelines: 1);
            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get(2);

            // Assert
            Assert.True(response is NotFoundResult);
        }

        [Fact]
        public void Get_Guidelines_ExceptionThrown_Returns400()
        {
            // Arrange
            TestMappings.Initialise();
            ISIGNService mockSIGNService =
                MockProvider.CreateMockSignService(
                    numberOfGuidelines: 1,
                    returnsException: true);

            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get();

            // Assert
            Assert.True(response is BadRequestObjectResult);
        }

        [Fact]
        public async void Post_Guideline_ReturnsCreatedResult201()
        {
            // Arrange
            TestMappings.Initialise();
            ISIGNService mockSIGNService =
                MockProvider.CreateMockSignService(numberOfGuidelines: 1);
            GuidelineViewModel guideline = TestDataProvider.CreateTestGuidelineViewModel(id: 1);

            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = await controller.Post(guideline);

            // Assert
            Assert.True(response is CreatedResult);
        }
    }
}
