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
        private IGuidelineService _guidelineService;

        public AssessmentController(IGuidelineService guidelineService)
        {
            _guidelineService = guidelineService;
        }

        [Authorize]
        public IActionResult Details(int id)
        {
            Assessment assessment = _guidelineService.GetAssessment(id);
            AssessmentViewModel model = Mapper.Map<AssessmentViewModel>(assessment);

            return View(model);
        }

        [Authorize]
        public IActionResult Step(int id)
        {
            Step step = _guidelineService.GetStep(id);
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
            StepAction action = _guidelineService.GetAction(stepId, condition);

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
    }
}
