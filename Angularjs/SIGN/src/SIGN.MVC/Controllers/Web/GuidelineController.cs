using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.MVC.ViewModels;

namespace SIGN.MVC.Controllers.Web
{
    public class GuidelineController : Controller
    {
        private IGuidelineService _guidelineService;

        public GuidelineController(IGuidelineService guidelineService)
        {
            _guidelineService = guidelineService;
        }

        [HttpGet, Authorize]
        public IActionResult AllGuidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _guidelineService.GetGuidelines();
            return View(model);
        }

        [HttpGet, Authorize]
        public IActionResult MyGuidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _guidelineService.GetMyGuidelines(User.Identity.Name);
            return View(model);
        }

        [HttpGet, Authorize]
        public IActionResult GuidelineDetails(int id)
        {
            Guideline guideline = _guidelineService.GetGuideline(id);
            GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);
            return View(model);
        }

        [HttpGet, Authorize]
        public IActionResult AddGuideline()
        {
            return View();
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public IActionResult AddGuideline(GuidelineViewModel newGuideline)
        {
            if (ModelState.IsValid)
            {
                newGuideline.Author = User.Identity.Name;
                _guidelineService.SaveGuideline(Mapper.Map<Guideline>(newGuideline));
                //RedirectToAction("GuidelineDetails", new { id = newGuideline.Id });
                RedirectToAction("AllGuidelines");
            }

            return View(newGuideline);
        }

        [HttpGet, Authorize]
        public IActionResult EditGuideline(int id)
        {
            Guideline guideline = _guidelineService.GetGuideline(id);
            if (guideline == null)
            {
                return RedirectToAction("AllGuidelines");
            }

            GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);
            return View(model);
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public IActionResult EditGuideline(GuidelineViewModel guideline)
        {
            if (ModelState.IsValid)
            {
                _guidelineService.SaveGuideline(Mapper.Map<Guideline>(guideline));
                return RedirectToAction("GuidelineDetails", new { id = guideline.Id });
            }

            return View(guideline);
        }
    }
}