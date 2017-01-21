using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace SIGN.Angular.Controllers.Web
{
    public class AppController : Controller
    {
        private ILogger<AppController> _logger;

        public AppController(
            ILogger<AppController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the home page: {ex.Message}");
                return Redirect("/error");
            }
        }

        [Authorize]
        public IActionResult Guidelines()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the Guidelines page: {ex.Message}");
                return Redirect("/error");
            }
        }

        public IActionResult About()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the About page: {ex.Message}");
                return Redirect("/error");
            }
        }
    }
}
