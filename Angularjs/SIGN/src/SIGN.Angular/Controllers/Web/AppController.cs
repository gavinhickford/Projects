using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SIGN.Angular.ViewModels;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System;

namespace SIGN.Angular.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _configuration;
        private ISIGNRepository _signRepository;
        private ISIGNService _signService;
        private ILogger<AppController> _logger;

        public AppController(
            ISIGNRepository signRepository, 
            ISIGNService signService,
            IConfigurationRoot configuration,
            ILogger<AppController> logger)
        {
            _signRepository = signRepository;
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
        public IActionResult Guidelines()
        {
            //GuidelinesViewModel model = new GuidelinesViewModel();
            //model.Guidelines = _signRepository.GetGuidelines();
            return View();
        }

        [Authorize]
        public IActionResult MyGuidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _signService.GetMyGuidelines(User.Identity.Name);
            return View(model);
        }

        public IActionResult Guideline(int id)
        {
            Guideline guideline = _signService.GetGuideline(id);
            GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);

            return View(model);
        }

        public IActionResult Assessment(int id)
        {
            Assessment assessment = _signRepository.GetAssessment(id);
            AssessmentViewModel model = Mapper.Map<AssessmentViewModel>(assessment);

            return View(model);
        }

        public IActionResult Step(int id)
        {
            Step step = _signRepository.GetStep(id);
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
            StepAction action = _signRepository.GetAction(stepId, condition);

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
