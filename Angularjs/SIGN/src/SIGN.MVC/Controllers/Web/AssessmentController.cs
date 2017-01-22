using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.MVC.ViewModels;

namespace SIGN.MVC.Controllers.Web
{
    public class AssessmentController : Controller
    {
        private IAssessmentService _assessmentService;

        public AssessmentController(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }

        [Authorize]
        public IActionResult Details(int id)
        {
            Assessment assessment = _assessmentService.GetAssessment(id);
            AssessmentViewModel model = Mapper.Map<AssessmentViewModel>(assessment);

            return View(model);
        }

        [Authorize]
        public IActionResult Step(int id)
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
    }
}
