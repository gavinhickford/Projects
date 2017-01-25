using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.MVC.ViewModels;
using System;

namespace SIGN.MVC.Controllers.Web
{
    /// <summary>
    /// Assessment Controller
    /// </summary>
    public class AssessmentController : Controller
    {
        private IAssessmentService _assessmentService;
        private ILogger<AssessmentController> _logger;

        public AssessmentController(
            IAssessmentService assessmentService, 
            ILogger<AssessmentController> logger)
        {
            _assessmentService = assessmentService;
            _logger = logger;
        }

        /// <summary>
        /// Displays the Assessments details view
        /// </summary>
        /// <param name="id">Assessment id</param>
        /// <returns>Assessment details view</returns>
        [Authorize]
        public IActionResult Details(int id)
        {
            try
            {
                Assessment assessment = _assessmentService.GetAssessment(id);
                AssessmentViewModel model = Mapper.Map<AssessmentViewModel>(assessment);

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the assessment details page: {ex.Message}");
                return Redirect("/error");
            }
        }

        /// <summary>
        /// Displays the step view
        /// </summary>
        /// <param name="id">Step id</param>
        /// <returns>Step View</returns>
        [Authorize]
        public IActionResult Step(int id)
        {
            try
            {
                Step step = _assessmentService.GetStep(id);
                StepViewModel model = Mapper.Map<StepViewModel>(step);

                Step yesStep = _assessmentService.GetNextStep(step.Id, true);
                Step noStep = _assessmentService.GetNextStep(step.Id, false);

                if (yesStep != null)
                {
                    model.YesStepId = yesStep.Id;
                };

                if (noStep != null)
                {
                    model.NoStepId = noStep.Id;
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the assessment step: {ex.Message}");
                return Redirect("/error");
            }
        }
    }
}
