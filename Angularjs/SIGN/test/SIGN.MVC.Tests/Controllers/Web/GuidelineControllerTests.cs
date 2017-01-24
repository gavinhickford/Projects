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
using System.Threading.Tasks;
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
            IGuidelineService mockGuidelineService = MockProvider.CreateMockGuidelineService(expectedNumberOfGuidelines);
            GuidelineController controller = new GuidelineController(mockGuidelineService, MockProvider.CreateMockLogger());

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
            GuidelineController controller = TestHelper.CreateController(expectedNumberOfGuidelines);

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
            GuidelineController controller = TestHelper.CreateController(userName, expectedNumberOfGuidelines);

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
            GuidelineController controller = TestHelper.CreateController(userName, expectedNumberOfGuidelines);

            // Act
            var result = controller.MyGuidelines() as ViewResult;
            IEnumerable<Guideline> actualGuidelines = (result.Model as GuidelinesViewModel).Guidelines;

            // Assert
            Assert.Empty(actualGuidelines);
        }

        [Fact]
        public async void AddGuideline_RedirectsToGuidelinesPage()
        {
            // Arrange
            TestMappings.Initialise();
            const string userName = "TestAuthor";
            const int expectedNumberOfGuidelines = 10;
            GuidelineController controller = TestHelper.CreateController(userName, expectedNumberOfGuidelines);

            GuidelineViewModel model = new GuidelineViewModel
            {
                Author ="Test",
                DatePublished = new System.DateTime(2010, 1, 1),
                Id = 0,
                Name = "Test Name",
                Number = 112,
                Status = Domain.Enums.GuidelineStatus.CurrentThreeToSevenYears
            };

            // Act
            var result = await controller.Add(model);

            // Assert
            Assert.Equal("AllGuidelines", (result as RedirectToActionResult).ActionName);
        }
    }
}
