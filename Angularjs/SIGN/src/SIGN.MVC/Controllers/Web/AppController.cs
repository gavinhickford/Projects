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
        private ISIGNService _signService;
        private ILogger<AppController> _logger;

        public AppController(
            ISIGNService signService, 
            IConfigurationRoot configuration,
            ILogger<AppController> logger)
        {
            _signService = signService;
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
        public IActionResult Assessment(int id)
        {
            Assessment assessment = _signService.GetAssessment(id);
            AssessmentViewModel model = Mapper.Map<AssessmentViewModel>(assessment);

            return View(model);
        }

        [Authorize]
        public IActionResult Step(int id)
        {
            Step step = _signService.GetStep(id);
            StepViewModel model = Mapper.Map<StepViewModel>(step);

            int? yesStepId = GetNextStepId(step.Id, true);
            int? noStepId = GetNextStepId(step.Id, false);

            if (yesStepId.HasValue)
            {
                model.YesStepId = yesStepId.Value;
            };

            if (noStepId.HasValue)
            {
                model.NoStepId = noStepId.Value;
            };

            return View(model);
        }

        private int? GetNextStepId(int stepId, bool condition)
        {
            StepAction action = _signService.GetAction(stepId, condition);

            if (action != null)
            {
                Step step = action.NextStep;
                if (step != null)
                {
                    return step.Id;
                }
            }

            return null;
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
