using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace SIGN.Angular.Controllers.Web
{
    /// <summary>
    /// The Application controller
    /// </summary>
    public class AppController : Controller
    {
        private ILogger<AppController> _logger;

        public AppController(
            ILogger<AppController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Display the Index view
        /// </summary>
        /// <returns>Index View</returns>
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

        /// <summary>
        /// Display the Guidelines View
        /// </summary>
        /// <returns>Guidelines View</returns>
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

        /// <summary>
        /// Displays the About View
        /// </summary>
        /// <returns>The About View</returns>
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
