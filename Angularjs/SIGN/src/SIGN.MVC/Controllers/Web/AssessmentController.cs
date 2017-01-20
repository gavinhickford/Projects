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
        private ISIGNService _signService;

        public AssessmentController(ISIGNService signService)
        {
            _signService = signService;
        }

        [Authorize]
        public IActionResult AssessmentDetails(int id)
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
    }
}
