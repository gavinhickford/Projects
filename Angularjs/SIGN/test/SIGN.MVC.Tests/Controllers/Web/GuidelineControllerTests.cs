using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.Mocks;
using SIGN.MVC.Controllers.Web;
using SIGN.MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Xunit;

namespace SIGN.MVC.Tests.Controllers.Web
{
    public class GuidelineControllerTests
    {
        [Fact]
        public void GetGuidelines_CorrectNumberOfGuidelinesReturned()
        {
            // Arrange
            const int expectedNumberOfGuidelines = 10;
            ISIGNService mockSignService = MockProvider.CreateMockSignService(expectedNumberOfGuidelines);
            GuidelineController controller = new GuidelineController(mockSignService);

            // Act
            var result = controller.AllGuidelines() as ViewResult;
            IEnumerable<Guideline> actualGuidelines = (result.Model as GuidelinesViewModel).Guidelines;

            // Assert
            Assert.Equal(expectedNumberOfGuidelines, actualGuidelines.Count());
        }

        [Fact]
        public void GetGuidelines_NoGuidelines_ReturnsEmptyList()
        {
            // Arrange
            const int expectedNumberOfGuidelines = 0;
            ISIGNService mockSignService = MockProvider.CreateMockSignService(expectedNumberOfGuidelines);
            GuidelineController controller = new GuidelineController(mockSignService);

            // Act
            var result = controller.AllGuidelines() as ViewResult;
            IEnumerable<Guideline> actualGuidelines = (result.Model as GuidelinesViewModel).Guidelines;

            // Assert
            Assert.Empty(actualGuidelines);
        }

        [Fact]
        public void MyGuidelines_CorrectNumberOfGuidelinesReturned()
        {
            // Arrange
            const string userName = "TestAuthor";
            const int expectedNumberOfGuidelines = 10;
            ISIGNService mockSignService = MockProvider.CreateMockSignService(
                numberOfGuidelines: expectedNumberOfGuidelines,
                author: userName,
                returnsException: false);
            GuidelineController controller = CreateController(mockSignService, userName);

            // Act
            var result = controller.MyGuidelines() as ViewResult;
            IEnumerable<Guideline> actualGuidelines = (result.Model as GuidelinesViewModel).Guidelines;

            // Assert
            Assert.Equal(expectedNumberOfGuidelines, actualGuidelines.Count());
        }

        [Fact]
        public void MyGuidelines_NoGuidelines_ReturnsEmptyList()
        {
            // Arrange
            const string userName = "TestAuthor";
            const int expectedNumberOfGuidelines = 0;
            ISIGNService mockSignService = MockProvider.CreateMockSignService(
                numberOfGuidelines: expectedNumberOfGuidelines,
                author: userName,
                returnsException: false);
            GuidelineController controller = CreateController(mockSignService, userName);

            // Act
            var result = controller.MyGuidelines() as ViewResult;
            IEnumerable<Guideline> actualGuidelines = (result.Model as GuidelinesViewModel).Guidelines;

            // Assert
            Assert.Empty(actualGuidelines);
        }

        private static GuidelineController CreateController(ISIGNService service, string currentUser)
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, currentUser)
            }));

            GuidelineController controller = new GuidelineController(service);
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = user }
            };

            return controller;
        }
    }
}
