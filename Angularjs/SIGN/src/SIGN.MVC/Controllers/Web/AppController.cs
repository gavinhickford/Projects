using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace SIGN.MVC.Controllers.Web
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
