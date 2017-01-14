﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Angular.Controllers.Api;
using SIGN.Angular.Tests.Mocks;
using SIGN.Angular.ViewModels;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System.Threading.Tasks;
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
            TestHelper.InitialiseMappings();
            ISIGNService mockSIGNService = TestHelper.CreateMockSignService(numberOfGuidelines: 1);
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
            TestHelper.InitialiseMappings();
            ISIGNService mockSIGNService = TestHelper.CreateMockSignService(numberOfGuidelines: 1);
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
            TestHelper.InitialiseMappings();
            ISIGNService mockSIGNService = TestHelper.CreateMockSignService(numberOfGuidelines: 1);
            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get(2);

            // Assert
            Assert.True(response is NotFoundResult);
        }

        [Fact]
        public void Get_Guidelines_ExceptionThrown_Returns400()
        {
            TestHelper.InitialiseMappings();
            ISIGNService mockSIGNService = 
                TestHelper.CreateMockSignService(
                    numberOfGuidelines: 1,
                    returnsException: true);

            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            // Act
            IActionResult response = controller.Get();

            Assert.True(response is BadRequestObjectResult);
        }

        [Fact]
        public async void Post_Guideline_ReturnsCreatedResult201()
        {
            TestHelper.InitialiseMappings();
            ISIGNService mockSIGNService =
                TestHelper.CreateMockSignService(
                    numberOfGuidelines: 1,
                    returnsException: true);
            GuidelineViewModel guideline = new GuidelineViewModel
            {
                Name = "TestName",
                Number = 110,
                Status = GuidelineStatus.CurrentLessThanThreeYears,
                Author = "TestUser",
                DateCreated = new System.DateTime(2004, 1, 1),
                DateModified = new System.DateTime(2004, 1, 1),
                DatePublished = new System.DateTime(2004, 1, 1),
            };

            var controller = new GuidelineController(mockSIGNService, _mockLogger);

            IActionResult response = await controller.Post(guideline);
            Assert.True(response is CreatedResult);
        }
    }
}
