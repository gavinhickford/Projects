using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace SIGN.MVC.Controllers.Web
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
        /// Displays the About view
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
                _logger.LogError($"Error getting the about page: {ex.Message}");
                return Redirect("/error");
            }
        }
    }
}
