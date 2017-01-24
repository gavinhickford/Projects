using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Interfaces;
using SIGN.Mocks;
using SIGN.MVC.Controllers.Web;
using System.Security.Claims;

namespace SIGN.MVC.Tests
{
    public static class TestHelper
    {
        internal static GuidelineController CreateController(int numberOfGuidelines)
        {
            return CreateController("TestUser", numberOfGuidelines);
        }

        internal static GuidelineController CreateController(string currentUser, int numberOfGuidelines)
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                 new Claim(ClaimTypes.Name, currentUser)
            }));

            IGuidelineService mockGuidelineService = MockProvider.CreateMockGuidelineService(
                numberOfGuidelines: numberOfGuidelines,
                author: currentUser,
                returnsException: false);

            GuidelineController controller = new GuidelineController(mockGuidelineService, MockProvider.CreateMockLogger());
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = user }
            };

            return controller;
        }
    }
}
