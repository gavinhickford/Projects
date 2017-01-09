using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.ViewModels;
using System;

namespace SIGN.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _configuration;
        private ISIGNRepository _signRepository;
        private ILogger<AppController> _logger;

        public AppController(
            ISIGNRepository signRepository, 
            IConfigurationRoot configuration,
            ILogger<AppController> logger)
        {
            _signRepository = signRepository;
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

        [Authorize]
        public IActionResult Guidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _signRepository.GetGuidelines();
            return View(model);
        }

        public IActionResult Guideline(int id)
        {
            Guideline guideline = _signRepository.GetGuideline(id);
            GuidelineViewModel model = new GuidelineViewModel
            {
                Name = guideline.Name,
                Assessments = guideline.Assessments,
                DatePublished = guideline.DatePublished,
                Number = guideline.Number
            };

            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            //if (model.Email.Contains("aol.com"))
            //{
            //    ModelState.AddModelError("", "We don't support AOL Addresses");
            //}

            //if (ModelState.IsValid)
            //{
            //    _mailService.SendMail(
            //        to: _configuration["MailSettings:ToAddress"],
            //        from: model.Email,
            //        subject: "From" + model.Name,
            //        body: model.Message);

            //    ModelState.Clear();

            //    ViewBag.UserMessage = "Message Sent";
            //}

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
