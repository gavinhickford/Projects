using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.MVC.ViewModels;
using System;

namespace SIGN.MVC.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _configuration;
        private IGuidelineService _guidelineService;
        private ILogger<AppController> _logger;

        public AppController(
            IGuidelineService guidelineService, 
            IConfigurationRoot configuration,
            ILogger<AppController> logger)
        {
            _guidelineService = guidelineService;
            _configuration = configuration;
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
            return View();
        }
    }
}
